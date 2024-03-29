﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileByteCompare
{
    public static class ErrorLogger
    {
        private static string _fileNeme = Directory.GetCurrentDirectory() + "\\errorLog.txt";
        public static string FileNeme { get { return _fileNeme; }  set { _fileNeme = value; } }

        public enum ErrorType
        {
            [TextAttribute("Unhandled Exception")]
            UnhandledException,

            [TextAttribute("Custom")]
            Custom,

            [TextAttribute("Unknown")]
            Unknown
        }

        public static void Log(ErrorType errorType, string errMsg, DateTime time)
        {
            string errorLogMsg =
                "\r\n=============================================================\r\n" +
                "Error time: " + time.ToString() + "\r\n" +
                "Error type: " + errorType.ToText()  +
                "\r\n-------------------------------------------------------------\r\n" +
                "\r\n" +
                errMsg +
                "\r\n=============================================================\r\n";

            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(FileNeme, FileMode.Append)))
                {
                    sw.Write(errorLogMsg);
                }
            }
            catch { }
        }
    }
}
