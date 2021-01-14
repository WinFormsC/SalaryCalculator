using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            surnameText.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void editSalary_Click(object sender, EventArgs e)
        {

        }

        private void addSalary_Click(object sender, EventArgs e)
        {
            Salary res = new Salary();
            try
            {
                // Проверка исключений
                if (String.IsNullOrWhiteSpace(surnameText.Text))
                    throw new Exception("Вы не ввели фамилию работника!");
                if (!Decimal.TryParse(salaryText.Text, out decimal salary))
                    throw new Exception("Вы не ввели зарплату работника!");
                // Присваивание значений
                res.Surname = surnameText.Text;
                res.Summ = salary;
                // Добавление в 2 списка
                listSalaries.Items.Add(res);
                
                //listResult.Items.Add(res);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            listSalaries.Items.Clear();
            listResult.Items.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
