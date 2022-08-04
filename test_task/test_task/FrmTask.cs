using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test_task
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            // Ömer Faruk Akyapak
            // Asenkron Kodlama

        }

        private delegate void VoidDelegate(string progress);
        private void Update(string progress)        //Invoke kullanımı
        {
            if (InvokeRequired)
            {
                var del = new VoidDelegate(Update);
                BeginInvoke(del, new[] { progress });
            }
            else
            {
                lblResult.Text = progress;
            }
        }

        private async void btnAction_Click(object sender, EventArgs e)  //Action-Task Kullanımı
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Update((i + 1).ToString());
                    Thread.Sleep(100);

                }
            });

            MessageBox.Show("İşlem Tamamlandı!", "Task/Action");

            /*
             *Action ı Task içinde anonymous bir fonksiyon olarak da yazabilirken aşağıdaki gibi bir Action açıp da yazabilirim.
             
            
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

        private async void btnIProgress_Click(object sender, EventArgs e) //Progress-Action-Task Kullanımı
        {
            Action<string> actionProgress = new Action<string>(data =>
            {
                lblResult.Text = data;
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

            MessageBox.Show("İşlem Tamamlandı!", "Task/IProgress");

            /*
             *Üst taraftaki kod satırlarında altta yaptığım işlerin en açık hali bulunmaktadır. 
             
            IProgress<string> progress = new Progress<string>(data =>
                {
                    lblResult.Text = data;
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

        private void btnBackGW_Click(object sender, EventArgs e)    //BackGroundWorker Kullanımı
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //Çalışırken yapacakları
        {
            for (int i = 0; i < 10; i++)
            {
                int perc = (i + 1) * 10;
                int data = i + 1;
                backgroundWorker1.ReportProgress(perc, data);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) //Return
        {
            string data = e.UserState.ToString();
            lblResult.Text = data;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //Result 
        {
            MessageBox.Show("İşlem Tamamlandı!", "Task/BackGW");
        }
    }
}
