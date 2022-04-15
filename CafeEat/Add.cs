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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void cafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet.Cafe". При необходимости она может быть перемещена или удалена.
            this.cafeTableAdapter.Fill(this.cafeDataSet.Cafe);

            this.cafeBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (названиеTextBox.Text.Length == 0 || единицы_измеренияTextBox.Text.Length == 0 || количество_товара_на_остаткахTextBox.Text.Length == 0 || 
                количество_тавара_в_чекеTextBox.Text.Length == 0 || цена_за_единицуTextBox.Text.Length == 0 || сумма_в_покупкеTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            this.Validate();
            this.cafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(количество_тавара_в_чекеTextBox.Text) * Convert.ToInt32(цена_за_единицуTextBox.Text);
            if (названиеTextBox.Text != "Комплексный обед")
            {
                if (sum >= 300 && sum <= 500) сумма_в_покупкеTextBox.Text = Convert.ToString(sum / 100 * 97);
                if (sum >= 501 && sum <= 1000) сумма_в_покупкеTextBox.Text = Convert.ToString(sum / 100 * 95);
                if (sum >= 1001 && sum <= 5000) сумма_в_покупкеTextBox.Text = Convert.ToString(sum / 100 * 93);
                if (sum > 5000) сумма_в_покупкеTextBox.Text = Convert.ToString(sum / 100 * 90);
            }
            else сумма_в_покупкеTextBox.Text = sum.ToString();
        }
    }
}
