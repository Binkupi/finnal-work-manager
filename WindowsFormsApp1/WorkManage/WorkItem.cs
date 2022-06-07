﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

//namespace WindowsFormsApp1.WorkManage
namespace WindowsFormsApp1

{
    public partial class workItem : UserControl
    {

        public WorkManagePage workReferenceForm;
        public Home homeReferenceForm;
        public WorkTypeManagePage workTypeReferenceForm;
        private string inputIdWorkType;
        //public workItem()
        //{
        //    InitializeComponent();
        //}

        //public workItem(WorkManagePage form1,string idWorkType)
        //{
        //    InitializeComponent();
        //    inputIdWorkType = idWorkType;
        //    this.ReferenceForm = form1;
        //}

        public workItem(Home form1, WorkTypeManagePage form2, WorkManagePage form3, string idWorkType,ClientModel client)
        {
            InitializeComponent();
            inputIdWorkType = idWorkType;
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.workReferenceForm = form3;
            this.client = client;
        }

        public workItem(Home form1,ClientModel client)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.client = client;
        }

        private void WorkItem_Load(object sender, EventArgs e)
        {

        }
        public string strName
        {
            get => txtName.Text;
            set
            {
                // trim if title is too long
                string txt = string.Copy(value);
                if (txt.Length != 0)
                {
                    int i = txt.Length;
                    while (TextRenderer.MeasureText(txt, txtName.Font).Width > txtName.Width - 6)
                    {
                        txt = value.Substring(0, --i);
                        if (i == 0) break;
                    }
                    txtName.Text = txt + "...";
                }
                else
                {
                    txtName.Text = value;
                }
            }
        }
        public string WorkType { get; set; }

        public ClientModel client { get; set; }

        public string WorkId { get; set; }

        public string strDate
        {
            get => txtDate.Text;
            set
            {
                txtDate.Text = value;
            }

        }
        public string strTime
        {
            get => txtTime.Text;
            set
            {
                txtTime.Text = value;
            }

        }
        
        public Color gbColor
        {
            get => background.BackColor;
            set
            {
                background.BackColor = value;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                WorkDao workDao = new WorkDao();
                string idWorkType = WorkType;
                workDao.delete(WorkId, client);
                //ReferenceForm.loadData(WorkType);
                
                if(this.workReferenceForm != null)
                {
                    workReferenceForm.loadData(inputIdWorkType);
                }
                this.homeReferenceForm.loadData();
                     
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn sửa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //AddWork addWork = new AddWork(WorkId, this.ReferenceForm, false);
                //addWork.Show();

                AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, false);
                addWork.Show();

               
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, true);
            addWork.Show();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, true);
            addWork.Show();
        }

    }
}
