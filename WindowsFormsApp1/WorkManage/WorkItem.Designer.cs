﻿
namespace WindowsFormsApp1

{
    partial class workItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.Label();
            this.elipseControl1 = new WindowsFormsApp1.ElipseControl();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(7, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 75);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Công việc";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDate.Location = new System.Drawing.Point(13, 9);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(76, 19);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Ngày giờ";
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // background
            // 
            this.background.Controls.Add(this.txtTime);
            this.background.Controls.Add(this.btnEdit);
            this.background.Controls.Add(this.txtDate);
            this.background.Controls.Add(this.btnDelete);
            this.background.Controls.Add(this.txtName);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(170, 170);
            this.background.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTime.Location = new System.Drawing.Point(13, 132);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(35, 20);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "Giờ";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WindowsFormsApp1.Properties.Resources._2530835_compose_create_edit_edit_file_office_icon;
            this.btnEdit.Location = new System.Drawing.Point(129, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 32);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources._6827792_delete_multimedia_remove_trash_ui_icon;
            this.btnDelete.Location = new System.Drawing.Point(86, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 32);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // workItem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.background);
            this.Name = "workItem";
            this.Size = new System.Drawing.Size(170, 170);
            this.Load += new System.EventHandler(this.WorkItem_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Label txtDate;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label txtTime;
    }
}
