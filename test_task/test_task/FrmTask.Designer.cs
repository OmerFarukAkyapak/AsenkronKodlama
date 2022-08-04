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
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(319, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(147, 35);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Numbers";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAction.Location = new System.Drawing.Point(115, 201);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(146, 74);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Counter Async  Task/Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnIProgress
            // 
            this.btnIProgress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIProgress.Location = new System.Drawing.Point(325, 201);
            this.btnIProgress.Name = "btnIProgress";
            this.btnIProgress.Size = new System.Drawing.Size(146, 74);
            this.btnIProgress.TabIndex = 2;
            this.btnIProgress.Text = "Counter Async  Task/IProgress";
            this.btnIProgress.UseVisualStyleBackColor = true;
            this.btnIProgress.Click += new System.EventHandler(this.btnIProgress_Click);
            // 
            // btnBackGW
            // 
            this.btnBackGW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackGW.Location = new System.Drawing.Point(548, 201);
            this.btnBackGW.Name = "btnBackGW";
            this.btnBackGW.Size = new System.Drawing.Size(146, 74);
            this.btnBackGW.TabIndex = 3;
            this.btnBackGW.Text = "Counter Async  Task/BackGW";
            this.btnBackGW.UseVisualStyleBackColor = true;
            this.btnBackGW.Click += new System.EventHandler(this.btnBackGW_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackGW);
            this.Controls.Add(this.btnIProgress);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblResult);
            this.Name = "FrmTask";
            this.Text = "TEST TASK - Ömer Faruk AKYAPAK";
            this.Load += new System.EventHandler(this.FrmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnIProgress;
        private System.Windows.Forms.Button btnBackGW;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}