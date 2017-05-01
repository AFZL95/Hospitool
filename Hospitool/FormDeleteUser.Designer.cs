namespace Hospitool
{
    partial class FormDeleteUser
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
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbReceptionist = new System.Windows.Forms.ComboBox();
            this.cbLabworker = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearPatient = new System.Windows.Forms.Button();
            this.btnClearDoctor = new System.Windows.Forms.Button();
            this.btnClearLabworker = new System.Windows.Forms.Button();
            this.btnClearReceptionist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(85, 163);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(121, 21);
            this.cbPatient.TabIndex = 0;
            this.cbPatient.SelectedIndexChanged += new System.EventHandler(this.cbPatient_SelectedIndexChanged);
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(316, 163);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbDoctor.TabIndex = 1;
            this.cbDoctor.SelectedIndexChanged += new System.EventHandler(this.cbDoctor_SelectedIndexChanged);
            // 
            // cbReceptionist
            // 
            this.cbReceptionist.FormattingEnabled = true;
            this.cbReceptionist.Location = new System.Drawing.Point(316, 280);
            this.cbReceptionist.Name = "cbReceptionist";
            this.cbReceptionist.Size = new System.Drawing.Size(121, 21);
            this.cbReceptionist.TabIndex = 2;
            this.cbReceptionist.SelectedIndexChanged += new System.EventHandler(this.cbReceptionist_SelectedIndexChanged);
            // 
            // cbLabworker
            // 
            this.cbLabworker.FormattingEnabled = true;
            this.cbLabworker.Location = new System.Drawing.Point(85, 280);
            this.cbLabworker.Name = "cbLabworker";
            this.cbLabworker.Size = new System.Drawing.Size(121, 21);
            this.cbLabworker.TabIndex = 3;
            this.cbLabworker.SelectedIndexChanged += new System.EventHandler(this.cbLabworker_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(234, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearPatient
            // 
            this.btnClearPatient.Location = new System.Drawing.Point(167, 190);
            this.btnClearPatient.Name = "btnClearPatient";
            this.btnClearPatient.Size = new System.Drawing.Size(39, 23);
            this.btnClearPatient.TabIndex = 5;
            this.btnClearPatient.Text = "Clear";
            this.btnClearPatient.UseVisualStyleBackColor = true;
            this.btnClearPatient.Click += new System.EventHandler(this.btnClearPatient_Click);
            // 
            // btnClearDoctor
            // 
            this.btnClearDoctor.Location = new System.Drawing.Point(398, 190);
            this.btnClearDoctor.Name = "btnClearDoctor";
            this.btnClearDoctor.Size = new System.Drawing.Size(39, 23);
            this.btnClearDoctor.TabIndex = 6;
            this.btnClearDoctor.Text = "Clear";
            this.btnClearDoctor.UseVisualStyleBackColor = true;
            this.btnClearDoctor.Click += new System.EventHandler(this.btnClearDoctor_Click);
            // 
            // btnClearLabworker
            // 
            this.btnClearLabworker.Location = new System.Drawing.Point(167, 307);
            this.btnClearLabworker.Name = "btnClearLabworker";
            this.btnClearLabworker.Size = new System.Drawing.Size(39, 23);
            this.btnClearLabworker.TabIndex = 7;
            this.btnClearLabworker.Text = "Clear";
            this.btnClearLabworker.UseVisualStyleBackColor = true;
            this.btnClearLabworker.Click += new System.EventHandler(this.btnClearLabworker_Click);
            // 
            // btnClearReceptionist
            // 
            this.btnClearReceptionist.Location = new System.Drawing.Point(398, 307);
            this.btnClearReceptionist.Name = "btnClearReceptionist";
            this.btnClearReceptionist.Size = new System.Drawing.Size(39, 23);
            this.btnClearReceptionist.TabIndex = 8;
            this.btnClearReceptionist.Text = "Clear";
            this.btnClearReceptionist.UseVisualStyleBackColor = true;
            this.btnClearReceptionist.Click += new System.EventHandler(this.btnClearReceptionist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Labworker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Receptionist";
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(557, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearReceptionist);
            this.Controls.Add(this.btnClearLabworker);
            this.Controls.Add(this.btnClearDoctor);
            this.Controls.Add(this.btnClearPatient);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbLabworker);
            this.Controls.Add(this.cbReceptionist);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.cbPatient);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.Load += new System.EventHandler(this.FormDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbReceptionist;
        private System.Windows.Forms.ComboBox cbLabworker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearPatient;
        private System.Windows.Forms.Button btnClearDoctor;
        private System.Windows.Forms.Button btnClearLabworker;
        private System.Windows.Forms.Button btnClearReceptionist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}