using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assi3._3
{
    public partial class btnExitStuInfo : Form
    {
        public btnExitStuInfo()
        {
            InitializeComponent();

            btnSubmitUpdate.Click += btnSubmitUpdate_Click;
        }

        //private void AddForm_Load(object sender, EventArgs e)
        //{
        //    combo
        //}

 
        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            var idText = textBox4.Text?.Trim() ?? string.Empty;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            string fName = txtFirstName.Text.Trim();
            string lName = textBox3.Text.Trim();
            string month = listBox1.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName))
            {
                MessageBox.Show("First name and last name are required.", "Missing data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char gradeChar = ' ';
            var gradeText = textBox6.Text.Trim();
            if (!string.IsNullOrEmpty(gradeText))
            {
                gradeChar = gradeText[0];
            }

            var student = new Student
            {
                Id = id,
                FName = fName,
                LName = lName,
                MonthAdmiited = month,
                Grade = gradeChar
            };

            Data_cs.students.Add(student);

            MessageBox.Show("Student added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting Student Info Form.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
