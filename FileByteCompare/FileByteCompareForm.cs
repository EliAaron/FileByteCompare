using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FileByteCompare
{
    public partial class FileByteCompareForm : Form
    {
        AppState AppState = AppState.Idle;

        Task CalcTask;
        CancellationTokenSource CanellCalcTask;
        int WaitForCalcCanellOrEndTiomout_ms = 3000;

        Color StopColor = Color.FromArgb(255, 165, 165);
        Color StopBorderColor = Color.FromArgb(255, 120, 120);

        Color StartColor = Color.FromArgb(135, 240, 135);
        Color StartBorderColor = Color.FromArgb(0, 192, 0);

        Properties.Settings Settings = Properties.Settings.Default;

        public FileByteCompareForm()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            SetButtonIdleState();

            Text += " v" + FileVersionInfo.GetVersionInfo(
                System.Reflection.Assembly.GetExecutingAssembly().Location)
                .FileVersion;

            txtOutput.AllowDrop = true;
            txtOutput.DragEnter += TxtOutput_DragEnter;
            txtOutput.DragDrop += TxtOutput_DragDrop;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            WaitForCommTastCanellOrEnd();

            base.OnClosing(e);
        }

        private void SetButtonIdleState()
        {
            btnBrowseFile1.Enabled = true;
            btnBrowseFile2.Enabled = true;
            btnCut.Enabled = true;
            btnClear.Enabled = true;
            btnCalcDiff.Text = "Compare";
            btnCalcDiff.BackColor = StartColor;
            btnCalcDiff.BorderColor = StartBorderColor;
        }

        private void SetButtonBuisyState()
        {
            btnBrowseFile1.Enabled = false;
            btnBrowseFile2.Enabled = false;
            btnCut.Enabled = false;
            btnClear.Enabled = false;
            btnCalcDiff.Text = "Cancel";
            btnCalcDiff.BackColor = StopColor;
            btnCalcDiff.BorderColor = StopBorderColor = Color.FromArgb(255, 120, 120);
            ;
        }

        private void Clac()
        {
            if (string.IsNullOrEmpty(txtFile1.Text) ||
                string.IsNullOrEmpty(txtFile2.Text))
            {
                ShowErrorMessage(
                    "Select two files!",
                    "!!!",
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (!File.Exists(txtFile1.Text) ||
                !File.Exists(txtFile2.Text))
            {
                ShowErrorMessage(
                    "File(s) not found",
                    "Error",
                    MessageBoxIcon.Error);

                return;
            }

            SetButtonBuisyState();

            AppState = AppState.Buisy;

            CanellCalcTask = new CancellationTokenSource();
            CalcTask = Task.Factory.StartNew((() =>
            {
                try
                {
                    int byteDiff = 0;

                    string fileName1 = txtFile1.Text;
                    string fileName2 = txtFile2.Text;

                    FileInfo fileInfo1 = new FileInfo(fileName1);

                    FileInfo fileInfo2 = new FileInfo(fileName2);

                    this.BeginInvoke(() =>
                    {
                        txtOutput.Clear();
                        txtOutput.WriteLine("File 1:");
                        txtOutput.WriteLine("\tName: {0}", txtFile1.Text);
                        txtOutput.WriteLine("\tSize: {0} Bytes", fileInfo1.Length);
                        txtOutput.WriteLine();

                        txtOutput.WriteLine("File 2:");
                        txtOutput.WriteLine("\tName: {0}", txtFile2.Text);
                        txtOutput.WriteLine("\tSize: {0} Bytes", fileInfo2.Length);
                        txtOutput.WriteLine();

                        txtOutput.WriteLine("Comparing files...");
                        txtOutput.WriteLine();
                    });

                    if (fileInfo1.Length == fileInfo2.Length)
                    {
                        using (FileStream fs1 = fileInfo1.OpenRead())
                        using (FileStream fs2 = fileInfo2.OpenRead())
                        {
                            for (int i = 0; i < fileInfo1.Length; i++)
                            {
                                if (CanellCalcTask.IsCancellationRequested)
                                {
                                    return;
                                }

                                if (fs1.ReadByte() != fs2.ReadByte())
                                {
                                    ++byteDiff;
                                }
                            }
                        }

                        if (byteDiff == 0)
                        {
                            this.BeginInvoke(() =>
                            {
                                txtOutput.WriteLine("Files are equal!");
                                txtOutput.WriteLine("Byte difference: {0}", byteDiff);
                            });
                        }
                        else
                        {
                            this.BeginInvoke(() =>
                            {
                                txtOutput.WriteLine("Files are NOT equal!");
                                txtOutput.WriteLine("Byte difference: {0}", byteDiff);
                            });
                        }
                    }
                    else
                    {
                        this.BeginInvoke(() =>
                        {
                            txtOutput.WriteLine("Files are not the same length!");
                        });
                    }
                }
                catch (Exception ex)
                {
                    this.BeginInvoke(() =>
                    {
                        ShowErrorMessage(
                            ex.Message,
                            "Error",
                            MessageBoxIcon.Error);
                    });
                }
                finally
                {
                    this.BeginInvoke(() =>
                    {
                        txtOutput.WriteLine();
                        if (!CanellCalcTask.IsCancellationRequested)
                        {
                            txtOutput.WriteLine("Done!");
                        }
                        else
                        {
                            txtOutput.WriteLine("Canceled");
                        }
                        SetButtonIdleState();

                        AppState = AppState.Idle;
                    });
                }
            }),
            CanellCalcTask.Token,
            TaskCreationOptions.None,
            TaskScheduler.Default);
        }

        private void ShowErrorMessage(
            string msg,
            string caption,
            MessageBoxIcon msgBoxIcon)
        {
            txtOutput.Text = caption + ":\n" + msg;

            MessageBox.Show(
                this,
                msg,
                caption,
                MessageBoxButtons.OK,
                msgBoxIcon);
        }

        private void WaitForCommTastCanellOrEnd()
        {
            if (IsTaskBuisy(CalcTask))
            {
                if (CanellCalcTask != null)
                    CanellCalcTask.Cancel();

                Stopwatch taskTimoutStopwatch = Stopwatch.StartNew();

                // Wait for the invokes (BeginInvoke) of the main thread in CalcTask to complete
                while (IsTaskBuisy(CalcTask))
                {
                    // Pump message queue - Allow BeginInvokes from CalcTask to finish.
                    //Application.DoEvents();

                    if (taskTimoutStopwatch.ElapsedMilliseconds > WaitForCalcCanellOrEndTiomout_ms)
                    {
                        string errMsg = string.Format(
                            "Unable to stop CalcTask (thread).\r\nTimeout: {0} ms.",
                            WaitForCalcCanellOrEndTiomout_ms);

                        ErrorLogger.Log(ErrorLogger.ErrorType.Custom, errMsg, DateTime.Now);

                        DialogResult dlgResult = MessageBox.Show(
                            this,
                            "An unexpected error accrued!\r\n" +
                            "Do you want to Continue?\r\n\r\n" +
                            "Yes: Application will attempt to Continue\r\n" +
                            "No: Application will attempt to close.\r\n",
                            "Unable to stop",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error);

                        if (dlgResult == DialogResult.No)
                        {
                            errMsg = "Unable to stop CalcTask (thread).\r\nAttempting to close.";
                            ErrorLogger.Log(ErrorLogger.ErrorType.Custom, errMsg, DateTime.Now);

                            taskTimoutStopwatch.Stop();
                            Application.ExitThread();
                            return;
                        }
                        else
                        {
                            errMsg = "Unable to stop CalcTask (thread).\r\nAttempting to Continue.";
                            ErrorLogger.Log(ErrorLogger.ErrorType.Custom, errMsg, DateTime.Now);

                            taskTimoutStopwatch.Restart();
                        }
                    }

                    // Pump message queue - Allow BeginInvokes from CalcTask to finish.
                    //Application.DoEvents();

                    // Check a few times if CalcTask has ended. 
                    for (int i = 0; (i < 5) && (IsTaskBuisy(CalcTask)); i++)
                    {
                        // Let CalcTask work
                        Thread.Sleep(10);
                        // Pump message queue - Allow BeginInvokes from CalcTask to finish.
                        Application.DoEvents();
                        // Let CalcTask end.
                        Thread.Sleep(10);
                    }

                }

                if (CanellCalcTask != null)
                {
                    CanellCalcTask.Dispose();
                    CanellCalcTask = null;
                }

            }
        }

        private bool IsTaskBuisy(Task task)
        {
            return
                task != null &&
                (task.Status != TaskStatus.Canceled &&
                task.Status != TaskStatus.RanToCompletion
                && task.Status != TaskStatus.Faulted);
        }

        private void SetFileNameToTextBox(TextBox txt, string fileName)
        {
            if (!string.IsNullOrEmpty(fileName) &&
                File.Exists(fileName))
            {
                txt.Text = fileName;
                txt.SelectionLength = txt.Text.Length;
                txt.ScrollToCaret();

                if (txt == txtFile1)
                {
                    Settings.BrowseFile1ParentDirectory = Path.GetDirectoryName(fileName);
                }
                else if (txt == txtFile2)
                {
                    Settings.BrowseFile2ParentDirectory = Path.GetDirectoryName(fileName);
                }

                Settings.Save();
            }
        }

        private static string[] GetFilesOnlyFromData(IDataObject data)
        {
            if (!data.GetDataPresent(DataFormats.FileDrop))
            {
                return null;
            }
            string[] files = (string[])data.GetData(DataFormats.FileDrop);
            files = files.Where(str => !string.IsNullOrEmpty(str) && File.Exists(str)).ToArray();
            return files;
        }

        private void btnBrowseFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (Directory.Exists(Settings.BrowseFile1ParentDirectory))
                openFileDialog.InitialDirectory = Settings.BrowseFile1ParentDirectory;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SetFileNameToTextBox(txtFile1, openFileDialog.FileName);
            }
        }

        private void btnBrowseFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (Directory.Exists(Settings.BrowseFile2ParentDirectory))
                openFileDialog.InitialDirectory = Settings.BrowseFile2ParentDirectory;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog.FileName;
                txtFile2.SelectionLength = txtFile2.Text.Length;


                Settings.BrowseFile2ParentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                Settings.Save();
            }
        }

        private void btnCalcDiff_Click(object sender, EventArgs e)
        {
            if(AppState == AppState.Idle)
            {
                Clac();
            }
            else if(AppState == AppState.Buisy)
            {
                WaitForCommTastCanellOrEnd();
            }
        }

        private void txtFile_DragEnter(Object sender, DragEventArgs e)
        {
            if (AppState == AppState.Idle)
            {
                string[] files = GetFilesOnlyFromData(e.Data);
                if (files != null && files.Length > 0)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void txtFile_DragDrop(object sender, DragEventArgs e)
        {
            if (AppState == AppState.Idle)
            {
                string[] files = GetFilesOnlyFromData(e.Data);

                if (files.Length == 1)
                {
                    TextBox txt = sender as TextBox;
                    if (txt != null)
                    {
                        SetFileNameToTextBox(txt, files[0]);
                    }
                }
                else if (files.Length > 1)
                {
                    SetFileNameToTextBox(txtFile1, files[0]);
                    SetFileNameToTextBox(txtFile2, files[1]);
                }
            }
        }

        private void TxtOutput_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = GetFilesOnlyFromData(e.Data);
            if (files != null && files.Length > 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TxtOutput_DragDrop(Object sender, DragEventArgs e)
        {
            if (AppState == AppState.Idle)
            {
                string[] files = GetFilesOnlyFromData(e.Data);

                if (files.Length > 1)
                {
                    SetFileNameToTextBox(txtFile1, files[0]);
                    SetFileNameToTextBox(txtFile2, files[1]);

                    Clac();
                }
            }
        }

        private void btnClear_Click(Object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void btnCopy_Click(Object sender, EventArgs e)
        {
            if(txtOutput.Text.Length > 0)
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }

        private void btnCut_Click(Object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                Clipboard.SetText(txtOutput.Text);
                txtOutput.Clear();
            }
        }
    }
}
