namespace test_task
{
    partial class Form1
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
            this.btnBasic = new System.Windows.Forms.Button();
            this.lbls1 = new System.Windows.Forms.Label();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnBasic
            // 
            this.btnBasic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasic.Location = new System.Drawing.Point(171, 204);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(105, 53);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.Text = "Sayaç";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbls1
            // 
            this.lbls1.AutoSize = true;
            this.lbls1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbls1.Location = new System.Drawing.Point(291, 67);
            this.lbls1.Name = "lbls1";
            this.lbls1.Size = new System.Drawing.Size(67, 25);
            this.lbls1.TabIndex = 2;
            this.lbls1.Text = "label1";
            // 
            // btnProgress
            // 
            this.btnProgress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProgress.Location = new System.Drawing.Point(282, 204);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(105, 53);
            this.btnProgress.TabIndex = 3;
            this.btnProgress.Text = "Sayaç Async";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackground.Location = new System.Drawing.Point(393, 204);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(166, 53);
            this.btnBackground.TabIndex = 4;
            this.btnBackground.Text = "Sayaç (BackgroundWorker)";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.button3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 397);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.lbls1);
            this.Controls.Add(this.btnBasic);
            this.Name = "Form1";
            this.Text = "TASK TEST - Ömer Faruk Akyapak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Label lbls1;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnBackground;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

