namespace Hospitool
{
    partial class FormReceptionist
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
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddpatient = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(286, 227);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteAppointment.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteAppointment.TabIndex = 0;
            this.btnDeleteAppointment.Text = "حذف قرار ملاقات";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.Location = new System.Drawing.Point(53, 227);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(139, 23);
            this.btnAddpatient.TabIndex = 6;
            this.btnAddpatient.Text = "اضافه کردن بیمار";
            this.btnAddpatient.UseVisualStyleBackColor = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hospitool.Properties.Resources.Remove_event;
            this.pictureBox6.Location = new System.Drawing.Point(286, 81);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(139, 140);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospitool.Properties.Resources.patient_icon_9245;
            this.pictureBox2.Location = new System.Drawing.Point(53, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(470, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAddpatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Name = "FormReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptionist";
            this.Load += new System.EventHandler(this.FormReceptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddpatient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnExit;
    }
}