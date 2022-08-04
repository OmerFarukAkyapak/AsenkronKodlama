using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_task
{
    public partial class Frm_Task : Form
    {
        public Frm_Task()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ömer Faruk Akyapak
            // Asenkron Kodlama
        }

        private delegate void VoidDelegate(string progress);
        private void Update(string progress)
        {
            if (InvokeRequired)
            {
                var del = new VoidDelegate(Update);
                BeginInvoke(del, new[] { progress });
            }
            else
            {
                lbls1.Text = progress;
            }
        }

        private async void button1_Click(object sender, EventArgs e)    //Action-Task Kullanımı
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Update((i + 1).ToString());
                    Thread.Sleep(100);

                }
            });

            MessageBox.Show("İşlem tamamlandı!");

            /*
             * 
            
            var action = new Action(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Update(i.ToString());
                        Thread.Sleep(100);                      
 
                    }
                });

            var task = new Task(action);
            task.Start();
            await task;

            */

        }

        private async void button2_Click(object sender, EventArgs e)    //Progress-Action-Task Kullanımı
        {
            Action<string> actionProgress = new Action<string>(data =>
                {
                    lbls1.Text = data;
                });

            IProgress<string> progress = new Progress<string>(actionProgress);

            Action actionTask = new Action(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        progress.Report((i + 1).ToString());
                        Thread.Sleep(100);
                    }
                });

            var task = Task.Run(actionTask);
            await task;

            MessageBox.Show("İşlem tamamlandı!");

            /*
             * 
            IProgress<string> progress = new Progress<string>(data =>
                {
                    lbls1.Text = data;
                });

            await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        progress.Report((i + 1).ToString());
                        Thread.Sleep(100);
                    }
                });

            */


        }

        private void button3_Click(object sender, EventArgs e)  //BackGroundWorker Kullanımı
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int perc = (i + 1) * 10;
                int data = i + 1;
                backgroundWorker1.ReportProgress(perc, data);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string data = e.UserState.ToString();
            lbls1.Text = data;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("İşlem tamamlandı!");
        }
    }
}
