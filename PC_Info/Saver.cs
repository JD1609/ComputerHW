using System;
using System.Windows;

namespace PC_Info
{
    public static class Saver
    {
        // ********************** SAVE TO DESKTOP ********************** \\
        public static void SaveToDesktop(MainWindow mw) 
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath += @"\HW_Info.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine(mw.UserLabel.Content + " " + Environment.UserName.ToString());
                file.WriteLine(mw.OSLabel.Content + " " + mw.OSLabelC.Content);
                file.WriteLine(mw.CPULabel.Content + " " + mw.CPULabelC.Content);
                file.WriteLine(mw.GPULabel.Content + " " + mw.GPULabelC.Content);
                file.WriteLine(mw.RAMLabel.Content + " " + mw.RAMLabelC.Content);
                file.WriteLine(mw.MBLabel.Content + " " + mw.MBLabelC.Content);
                file.WriteLine();
            }
        }

        // ********************** SAVE TO CLIPBOARD ********************** \\
        public static void SaveToClipboard(MainWindow mw)
        {
            string data = String.Format("{0} {1}\n{2} {3}\n{4} {5}\n{6} {7}\n{8} {9}\n{10} {11}",
                mw.UserLabel.Content, Environment.UserName.ToString(), //user
                mw.OSLabel.Content, mw.OSLabelC.Content, //OS
                mw.CPULabel.Content, mw.CPULabelC.Content, //CPU
                mw.GPULabel.Content, mw.GPULabelC.Content, //GPU
                mw.RAMLabel.Content, mw.RAMLabelC.Content, //RAM
                mw.MBLabel.Content, mw.MBLabelC.Content); //MB

            Clipboard.SetText(data);
        }
    }
}
