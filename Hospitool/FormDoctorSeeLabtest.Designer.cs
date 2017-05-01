namespace Hospitool
{
    partial class FormDoctorSeeLabtest
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
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPatients
            // 
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(106, 265);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(153, 21);
            this.cbPatients.TabIndex = 0;
            this.cbPatients.SelectedIndexChanged += new System.EventHandler(this.cbPatients_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(106, 301);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(153, 23);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "مشاهده نتایج آزمایش";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 236);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "بیمار را انتخاب کنید:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospitool.Properties.Resources.adobe_acrobat_pdf_file_512;
            this.pictureBox1.Location = new System.Drawing.Point(106, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormDoctorSeeLabtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(373, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.cbPatients);
            this.Name = "FormDoctorSeeLabtest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctorSeeLabtest";
            this.Load += new System.EventHandler(this.FormDoctorSeeLabtest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}