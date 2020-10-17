using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lab._1Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void TbStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLab1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseLab1DataSet.TbUsp". При необходимости она может быть перемещена или удалена.
            this.tbUspTableAdapter.Fill(this.databaseLab1DataSet.TbUsp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseLab1DataSet.TbPredmet". При необходимости она может быть перемещена или удалена.
            this.tbPredmetTableAdapter.Fill(this.databaseLab1DataSet.TbPredmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseLab1DataSet.TbTeachers". При необходимости она может быть перемещена или удалена.
            this.tbTeachersTableAdapter.Fill(this.databaseLab1DataSet.TbTeachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseLab1DataSet.TbStudents". При необходимости она может быть перемещена или удалена.
            this.tbStudentsTableAdapter.Fill(this.databaseLab1DataSet.TbStudents);
        }
    }
}
