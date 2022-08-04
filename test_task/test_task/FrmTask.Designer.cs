namespace test_task
{
    partial class FrmTask
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnIProgress = new System.Windows.Forms.Button();
            this.btnBackGW = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.DarkGray;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(22, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 39);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "10";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAction.Location = new System.Drawing.Point(12, 114);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(146, 74);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Counter Async  Task/Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnIProgress
            // 
            this.btnIProgress.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIProgress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIProgress.Location = new System.Drawing.Point(188, 114);
            this.btnIProgress.Name = "btnIProgress";
            this.btnIProgress.Size = new System.Drawing.Size(146, 74);
            this.btnIProgress.TabIndex = 2;
            this.btnIProgress.Text = "Counter Async  Task/IProgress";
            this.btnIProgress.UseVisualStyleBackColor = false;
            this.btnIProgress.Click += new System.EventHandler(this.btnIProgress_Click);
            // 
            // btnBackGW
            // 
            this.btnBackGW.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackGW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackGW.Location = new System.Drawing.Point(362, 114);
            this.btnBackGW.Name = "btnBackGW";
            this.btnBackGW.Size = new System.Drawing.Size(146, 74);
            this.btnBackGW.TabIndex = 3;
            this.btnBackGW.Text = "Counter Async  Task/BackGW";
            this.btnBackGW.UseVisualStyleBackColor = false;
            this.btnBackGW.Click += new System.EventHandler(this.btnBackGW_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btAll
            // 
            this.btAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAll.Location = new System.Drawing.Point(188, 216);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(146, 74);
            this.btAll.TabIndex = 4;
            this.btAll.Text = "Click All Counter ";
            this.btAll.UseVisualStyleBackColor = false;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(212, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 59);
            this.panel1.TabIndex = 5;
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(526, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAll);
            this.Controls.Add(this.btnBackGW);
            this.Controls.Add(this.btnIProgress);
            this.Controls.Add(this.btnAction);
            this.Name = "FrmTask";
            this.Text = "TEST TASK - Ömer Faruk AKYAPAK";
            this.Load += new System.EventHandler(this.FrmTask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnIProgress;
        private System.Windows.Forms.Button btnBackGW;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Panel panel1;
    }
}