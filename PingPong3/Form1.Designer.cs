﻿namespace PingPong3
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
            this.components = new System.ComponentModel.Container();
            this.pbTitleScreen = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTitleScreen
            // 
            this.pbTitleScreen.Location = new System.Drawing.Point(30, 22);
            this.pbTitleScreen.Name = "pbTitleScreen";
            this.pbTitleScreen.Size = new System.Drawing.Size(100, 50);
            this.pbTitleScreen.TabIndex = 0;
            this.pbTitleScreen.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.Location = new System.Drawing.Point(312, 67);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(35, 35);
            this.pbBall.TabIndex = 1;
            this.pbBall.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(12, 178);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(65, 160);
            this.pbPlayer1.TabIndex = 2;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(725, 230);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(65, 160);
            this.pbPlayer2.TabIndex = 3;
            this.pbPlayer2.TabStop = false;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 16;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // DrawTimer
            // 
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 16;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(337, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 181);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblScore2.Location = new System.Drawing.Point(594, 126);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(166, 181);
            this.lblScore2.TabIndex = 8;
            this.lblScore2.Text = "0";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblScore1.Location = new System.Drawing.Point(54, 126);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(166, 181);
            this.lblScore1.TabIndex = 7;
            this.lblScore1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(793, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbTitleScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTitleScreen;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
    }
}

