namespace FileByteCompare
{
    partial class FileByteCompareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileByteCompareForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCut = new AKANet.WinForms.Controls.CustomButton();
            this.btnCopy = new AKANet.WinForms.Controls.CustomButton();
            this.btnClear = new AKANet.WinForms.Controls.CustomButton();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnCalcDiff = new AKANet.WinForms.Controls.CustomButton();
            this.btnBrowseFile1 = new AKANet.WinForms.Controls.CustomButton();
            this.btnBrowseFile2 = new AKANet.WinForms.Controls.CustomButton();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCut);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Controls.Add(this.btnCalcDiff);
            this.panel1.Controls.Add(this.btnBrowseFile1);
            this.panel1.Controls.Add(this.btnBrowseFile2);
            this.panel1.Controls.Add(this.txtFile2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFile1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 662);
            this.panel1.TabIndex = 109;
            // 
            // btnCut
            // 
            this.btnCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCut.BoarderWidth = 1.5F;
            this.btnCut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCut.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.Location = new System.Drawing.Point(96, 182);
            this.btnCut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCut.Name = "btnCut";
            this.btnCut.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnCut.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnCut.Size = new System.Drawing.Size(74, 42);
            this.btnCut.TabIndex = 116;
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopy.BoarderWidth = 1.5F;
            this.btnCopy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCopy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopy.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(20, 182);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnCopy.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnCopy.Size = new System.Drawing.Size(74, 42);
            this.btnCopy.TabIndex = 115;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.BoarderWidth = 1.5F;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(172, 182);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnClear.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnClear.Size = new System.Drawing.Size(74, 42);
            this.btnClear.TabIndex = 114;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.Color.LightCyan;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(20, 226);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(840, 415);
            this.txtOutput.TabIndex = 113;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            // 
            // btnCalcDiff
            // 
            this.btnCalcDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcDiff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(240)))), ((int)(((byte)(135)))));
            this.btnCalcDiff.BoarderWidth = 1.5F;
            this.btnCalcDiff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcDiff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(240)))), ((int)(((byte)(135)))));
            this.btnCalcDiff.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnCalcDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCalcDiff.Location = new System.Drawing.Point(350, 128);
            this.btnCalcDiff.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcDiff.Name = "btnCalcDiff";
            this.btnCalcDiff.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnCalcDiff.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnCalcDiff.Size = new System.Drawing.Size(178, 63);
            this.btnCalcDiff.TabIndex = 111;
            this.btnCalcDiff.Text = "Calc";
            this.btnCalcDiff.Click += new System.EventHandler(this.btnCalcDiff_Click);
            // 
            // btnBrowseFile1
            // 
            this.btnBrowseFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseFile1.BoarderWidth = 1.5F;
            this.btnBrowseFile1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnBrowseFile1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseFile1.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnBrowseFile1.Location = new System.Drawing.Point(748, 9);
            this.btnBrowseFile1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFile1.Name = "btnBrowseFile1";
            this.btnBrowseFile1.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnBrowseFile1.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnBrowseFile1.Size = new System.Drawing.Size(112, 45);
            this.btnBrowseFile1.TabIndex = 107;
            this.btnBrowseFile1.Text = "Browse";
            this.btnBrowseFile1.Click += new System.EventHandler(this.btnBrowseFile1_Click);
            // 
            // btnBrowseFile2
            // 
            this.btnBrowseFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseFile2.BoarderWidth = 1.5F;
            this.btnBrowseFile2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnBrowseFile2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseFile2.FillStyle = AKANet.WinForms.Controls.FillStyle.Glow;
            this.btnBrowseFile2.Location = new System.Drawing.Point(748, 63);
            this.btnBrowseFile2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFile2.Name = "btnBrowseFile2";
            this.btnBrowseFile2.OuterBoundPaint = AKANet.WinForms.Controls.OuterBoundPaint.ParentBackColor;
            this.btnBrowseFile2.ShapeStyle = AKANet.WinForms.Controls.ShapeStyle.Rectangle;
            this.btnBrowseFile2.Size = new System.Drawing.Size(112, 45);
            this.btnBrowseFile2.TabIndex = 106;
            this.btnBrowseFile2.Text = "Browse";
            this.btnBrowseFile2.Click += new System.EventHandler(this.btnBrowseFile2_Click);
            // 
            // txtFile2
            // 
            this.txtFile2.AllowDrop = true;
            this.txtFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile2.BackColor = System.Drawing.SystemColors.Info;
            this.txtFile2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile2.Location = new System.Drawing.Point(90, 69);
            this.txtFile2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(648, 30);
            this.txtFile2.TabIndex = 103;
            this.txtFile2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile_DragDrop);
            this.txtFile2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = "File 2";
            // 
            // txtFile1
            // 
            this.txtFile1.AllowDrop = true;
            this.txtFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile1.BackColor = System.Drawing.SystemColors.Info;
            this.txtFile1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile1.Location = new System.Drawing.Point(90, 15);
            this.txtFile1.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(648, 30);
            this.txtFile1.TabIndex = 101;
            this.txtFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile_DragDrop);
            this.txtFile1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 102;
            this.label2.Text = "File 1";
            // 
            // FileByteCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(876, 662);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileByteCompareForm";
            this.Text = "File Byte Compare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.Label label3;
        private AKANet.WinForms.Controls.CustomButton btnBrowseFile1;
        private AKANet.WinForms.Controls.CustomButton btnBrowseFile2;
        private AKANet.WinForms.Controls.CustomButton btnCalcDiff;
        private System.Windows.Forms.RichTextBox txtOutput;
        private AKANet.WinForms.Controls.CustomButton btnClear;
        private AKANet.WinForms.Controls.CustomButton btnCut;
        private AKANet.WinForms.Controls.CustomButton btnCopy;
    }
}

