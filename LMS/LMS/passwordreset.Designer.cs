﻿namespace LMS
{
    partial class changepassword
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
            this.newpasswordlabel = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.changepasswordgroupbox = new System.Windows.Forms.GroupBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.newpasswordtextbox = new System.Windows.Forms.TextBox();
            this.errormessagelabel = new System.Windows.Forms.Label();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.changepasswordgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newpasswordlabel
            // 
            this.newpasswordlabel.AutoSize = true;
            this.newpasswordlabel.Location = new System.Drawing.Point(7, 43);
            this.newpasswordlabel.Name = "newpasswordlabel";
            this.newpasswordlabel.Size = new System.Drawing.Size(80, 13);
            this.newpasswordlabel.TabIndex = 1;
            this.newpasswordlabel.Text = "New password:";
            this.newpasswordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(92, 17);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(100, 20);
            this.idtextbox.TabIndex = 2;
            // 
            // changepasswordgroupbox
            // 
            this.changepasswordgroupbox.Controls.Add(this.exitbutton);
            this.changepasswordgroupbox.Controls.Add(this.passwordcheckbox);
            this.changepasswordgroupbox.Controls.Add(this.backbutton);
            this.changepasswordgroupbox.Controls.Add(this.resetbutton);
            this.changepasswordgroupbox.Controls.Add(this.usernamelabel);
            this.changepasswordgroupbox.Controls.Add(this.newpasswordlabel);
            this.changepasswordgroupbox.Controls.Add(this.newpasswordtextbox);
            this.changepasswordgroupbox.Controls.Add(this.idtextbox);
            this.changepasswordgroupbox.Location = new System.Drawing.Point(12, 30);
            this.changepasswordgroupbox.Name = "changepasswordgroupbox";
            this.changepasswordgroupbox.Size = new System.Drawing.Size(262, 95);
            this.changepasswordgroupbox.TabIndex = 4;
            this.changepasswordgroupbox.TabStop = false;
            this.changepasswordgroupbox.Text = "Reset Password";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(93, 66);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(12, 66);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 4;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(65, 20);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(21, 13);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "ID:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newpasswordtextbox
            // 
            this.newpasswordtextbox.Location = new System.Drawing.Point(92, 40);
            this.newpasswordtextbox.Name = "newpasswordtextbox";
            this.newpasswordtextbox.Size = new System.Drawing.Size(100, 20);
            this.newpasswordtextbox.TabIndex = 3;
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(9, 9);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(265, 18);
            this.errormessagelabel.TabIndex = 6;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.Location = new System.Drawing.Point(198, 39);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(53, 17);
            this.passwordcheckbox.TabIndex = 6;
            this.passwordcheckbox.Text = "Show";
            this.passwordcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged_1);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(174, 66);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 137);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.changepasswordgroupbox);
            this.Name = "changepassword";
            this.Text = "Password Reset Window";
            this.changepasswordgroupbox.ResumeLayout(false);
            this.changepasswordgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label newpasswordlabel;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.GroupBox changepasswordgroupbox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label errormessagelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox newpasswordtextbox;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.Button exitbutton;
    }
}