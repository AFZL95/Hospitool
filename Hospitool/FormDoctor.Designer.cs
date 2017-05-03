namespace Hospitool
{
    partial class FormDoctor
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
            this.btnAppointments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLabtestResult = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(152, 196);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAppointments.Size = new System.Drawing.Size(137, 23);
            this.btnAppointments.TabIndex = 0;
            this.btnAppointments.Text = "قرار ملاقات های من";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnLabtestResult
            // 
            this.btnLabtestResult.Location = new System.Drawing.Point(152, 408);
            this.btnLabtestResult.Name = "btnLabtestResult";
            this.btnLabtestResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLabtestResult.Size = new System.Drawing.Size(137, 23);
            this.btnLabtestResult.TabIndex = 6;
            this.btnLabtestResult.Text = "نتایج آزمایش بیماران";
            this.btnLabtestResult.UseVisualStyleBackColor = true;
            this.btnLabtestResult.Click += new System.EventHandler(this.btnLabtestResult_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospitool.Properties.Resources.test_tube;
            this.pictureBox2.Location = new System.Drawing.Point(150, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospitool.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(150, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(470, 521);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLabtestResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppointments);
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLabtestResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
    }
}