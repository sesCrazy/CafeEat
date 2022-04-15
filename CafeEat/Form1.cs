using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeEat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet.Cafe". При необходимости она может быть перемещена или удалена.
            this.cafeTableAdapter.Fill(this.cafeDataSet.Cafe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();

            int row, col;
            row = cafeDataGridView.CurrentCell.RowIndex;
            col = cafeDataGridView.CurrentCell.ColumnIndex;

            this.cafeTableAdapter.Fill(this.cafeDataSet.Cafe);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.data.kod = Convert.ToInt32(cafeDataGridView[0, cafeDataGridView.CurrentCell.RowIndex].Value);

            Change change = new Change();
            change.ShowDialog();

            this.cafeTableAdapter.Fill(this.cafeDataSet.Cafe);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Удалить запись?", "Потвердите удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Удаляем текущую запись
                cafeBindingSource.RemoveCurrent();
                this.Validate();
                this.cafeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cafeDataSet);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cafeDataGridView.RowCount - 1; i++)
                {
                    if (cafeDataGridView[1, i].Value.ToString().Contains(textBox1.Text) == true)
                        cafeDataGridView.CurrentCell = cafeDataGridView[1, i];
                }
            }
            catch { }
        }
    }
}
