using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly Employee worker = new Employee();
        User ist = new User();
        List<User> users = new List<User>();
        private int indexRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            
            worker.Name = ad.Text;
            worker.Surname = soyad.Text;
            worker.Position = position.Text;
            worker.Email = mail.Text;
            worker.Salary = Convert.ToDouble(salaryy.Text);

            users.Add(worker);

            if (button1.Text == "Update")
            {
                dataGridView1.CurrentRow.Cells[1].Value = ad.Text;
                dataGridView1.CurrentRow.Cells[2].Value = soyad.Text;
                dataGridView1.CurrentRow.Cells[3].Value = mail.Text;
                dataGridView1.CurrentRow.Cells[4].Value = position.Text;
                dataGridView1.CurrentRow.Cells[5].Value = salaryy.Text;
            }
            else
            {
                dataGridView1.Rows.Add(worker.getId(), worker.Name.ToString(), worker.Surname.ToString(), worker.Email.ToString(), worker.Position.ToString(), worker.Salary);
            }
           
            ad.Text = String.Empty;
                soyad.Text = String.Empty;
                mail.Text = String.Empty;
                position.Text = String.Empty;
                salaryy.Text = String.Empty;

            button1.Text = "Save";

        }
         
    private void Button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
    
    }
    
       private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            button1.Text = "Update";

            indexRow = e.RowIndex;

           
        DataGridViewRow selectedRow = dataGridView1.Rows[indexRow];
            ad.Text = selectedRow.Cells[1].Value.ToString();
            soyad.Text = selectedRow.Cells[2].Value.ToString();
            mail.Text = selectedRow.Cells[3].Value.ToString();
            position.Text = selectedRow.Cells[4].Value.ToString();
            salaryy.Text = selectedRow.Cells[5].Value.ToString();
           
        }
    }
}
