namespace GameTracker
{
    partial class TimerInterface
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textCreditCounter = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(101, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(32, 12);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(139, 26);
            this.textResult.TabIndex = 2;
            this.textResult.Text = "00:00:00";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textResult.TextChanged += new System.EventHandler(this.TextResult_TextChanged);
            // 
            // textCreditCounter
            // 
            this.textCreditCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCreditCounter.Location = new System.Drawing.Point(54, 88);
            this.textCreditCounter.Name = "textCreditCounter";
            this.textCreditCounter.Size = new System.Drawing.Size(26, 26);
            this.textCreditCounter.TabIndex = 3;
            this.textCreditCounter.Text = "00";
            this.textCreditCounter.TextChanged += new System.EventHandler(this.TextCreditCounter_TextChanged);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCredits.Location = new System.Drawing.Point(86, 91);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(59, 20);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = "Credits";
            this.lblCredits.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TimerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 129);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.textCreditCounter);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerInterface_FormClosing);
            this.Load += new System.EventHandler(this.TimerInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textCreditCounter;
        private System.Windows.Forms.Label lblCredits;
    }
}

