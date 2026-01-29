namespace Assi3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Mainform.AutoGenerateColumns = true;
            Mainform.DataSource = Data_cs.students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mainform.DataSource = Data_cs.students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Mainform.CurrentRow != null)
                {
                    Data_cs.students.RemoveAt(Mainform.CurrentRow.Index);
                    Mainform.DataSource = null;
                    Mainform.DataSource = Data_cs.students;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Mainform.DataSource = Enum.GetValues(typeof();
            btnExitStuInfo addStudentForm = new btnExitStuInfo();
            var dlg= addStudentForm.ShowDialog();
            if (dlg==DialogResult.OK)
            {
                Mainform.DataSource = null;
                Mainform.DataSource = Data_cs.students;
            }
        }
    }
}
