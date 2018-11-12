using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoToMP3
{
    public partial class mainForm : Form
    {
        //private Process process;

        public mainForm()
        {
            InitializeComponent();
        }


        #region 监控线程是否全部完成

        ////每秒检次一次线程池的状态
        //RegisteredWaitHandle rhw = ThreadPool.RegisterWaitForSingleObject(AutoResetEvent(false), this.CheckThreadPool, null, 1000, false);
        
        ////检查线程池的方法
        //private void CheckThreadPool(object state, bool timeout)
        //{
        //    int workerThreads = 0;
        //    int maxWordThreads = 0;
        //    //int 
        //    int compleThreads = 0;
        //    ThreadPool.GetAvailableThreads(out workerThreads, out compleThreads);
        //    ThreadPool.GetMaxThreads(out maxWordThreads, out compleThreads);
        //    //当可用的线数与池程池最大的线程相等时表示线程池中所有的线程已经完成
        //    if (workerThreads == maxWordThreads)
        //    {
        //        //当执行此方法后CheckThreadPool将不再执行
        //        rhw.Unregister(null);
        //        //此处加入所有线程完成后的处理代码
        //        lab_state.Text = "转换完成。";
        //    }
        //}

        #endregion


        private void btn_convert_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            List<string> files = helper.GetFiles(tb_inputPath.Text);
            ThreadPool.SetMaxThreads(5, 5);
            foreach (string file in files)
            {
                if (chb_rename.Checked)
                {
                    ThreadPool.QueueUserWorkItem(ChangeFileName, file);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(tb_outputPath.Text))
                    {
                        if (MessageBox.Show("未指定输出路径，是否输出到输入文件所在路径？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            tb_outputPath.Text = Path.GetDirectoryName(tb_inputPath.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    lab_state.Text = "正在转换...";
                    ThreadPool.QueueUserWorkItem(ConvertToMP3, file);
                }
            }
        }

        /// <summary>
        /// 转换到MP3
        /// </summary>
        /// <param name="file"></param>
        public void ConvertToMP3(object file)
        {
            string mp3name = Path.GetFileNameWithoutExtension(file.ToString()) + ".mp3";
            string command = $"-i \"{file}\" -f mp3 \"{Path.Combine(tb_outputPath.Text, mp3name)}\"";

            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg.exe"; //"\"D:\\Program Files\\ffmpeg-3.4.1-win64-static\\bin\\ffmpeg.exe\"";
            process.StartInfo.Arguments = command;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
        }

        /// <summary>
        /// 给文件名添加随机前缀
        /// </summary>
        /// <param name="file"></param>
        private void ChangeFileName(object file)
        {
            Random random = new Random();
            string path = Path.GetDirectoryName(file.ToString());
            string fileName = random.Next(0, 100) + "_" + Path.GetFileName(file.ToString());
            File.Move(file.ToString(), Path.Combine(path, fileName));
        }

        private void tb_inputPath_DragDrop(object sender, DragEventArgs e)
        {
            var tb = sender as TextBox;
            tb.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void tb_inputPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
