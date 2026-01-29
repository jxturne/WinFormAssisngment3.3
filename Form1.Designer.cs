namespace Assi3._3
{
  
    partial class Form1
    {
     
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mainform = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            lblStudentTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)Mainform).BeginInit();
            SuspendLayout();
            // 
            // Mainform
            // 
            Mainform.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Mainform.Location = new Point(230, 165);
            Mainform.Name = "Mainform";
            Mainform.RowHeadersWidth = 62;
            Mainform.Size = new Size(567, 225);
            Mainform.TabIndex = 0;
            Mainform.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(216, 494);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New Record";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(575, 494);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblStudentTitle
            // 
            lblStudentTitle.AutoSize = true;
            lblStudentTitle.Location = new Point(410, 80);
            lblStudentTitle.Name = "lblStudentTitle";
            lblStudentTitle.Size = new Size(172, 25);
            lblStudentTitle.TabIndex = 3;
            lblStudentTitle.Text = "Student Information";
            lblStudentTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 614);
            Controls.Add(lblStudentTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(Mainform);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Mainform).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Mainform;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblStudentTitle;
    }
}
