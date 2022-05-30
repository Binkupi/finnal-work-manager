﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAO
{
    public class WorkDao
    {
        Sql sql = new Sql();
        public DataTable getListWork()
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;
            

        }
        public DataTable getListWorkByWorkType(string workType)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work where workType = '"+workType+"'");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public DataTable getWorkByWorkID(string id)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work where id='"+id+"'");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public void delete(string id)
        {

            string query = "DELETE FROM work WHERE id ='"+id+"'";
            bool result = sql.delete(query);
            if (result)
            {
                MessageBox.Show("xóa thành công.");
            }

        }
        public void insert(Work work)
        {

            string query = "INSERT INTO `work` (`id`, `name`, `workType`, `startDate`, `deadline`, `description`, `backgroundColor`, `isFinished`) VALUES('"+work.Id+"', '"+work.Name+"', '"+work.WorkType+"', '"+work.StartDate.ToString("yyyy-MM-dd HH:mm") + "', '"+work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', '"+work.Description+"', '"+work.BackgroundColor+"',"+work.IsFinished+")";
            bool result = sql.insert(query);
            if (result)
            {
                MessageBox.Show("Lưu thành công.");
            }
                
        }
        public void update(Work work)
        {
            string query = "UPDATE `work` set `name` = '" + work.Name + "', `workType` ='" + work.WorkType + "', `startDate`='"+ work.StartDate.ToString("yyyy-MM-dd HH:mm") + "', `deadline`='"+ work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', `description`='"+ work.Description + "', `backgroundColor`='"+work.BackgroundColor + "', `isFinished`= "+work.IsFinished +" where id='"+work.Id+"'";
            MessageBox.Show(query);
            bool result = sql.update(query);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
            }
                
        }

    }
}