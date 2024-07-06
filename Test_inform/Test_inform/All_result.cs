using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_inform
{
    public partial class All_result : Form
    {
        Test_informationEntities entities = new Test_informationEntities();

        public All_result()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test_start test_Start = new Test_start();
            test_Start.Show();
        }

        private void All_result_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_informationDataSet.all_result". При необходимости она может быть перемещена или удалена.
            this.all_resultTableAdapter.Fill(this.test_informationDataSet.all_result);

        }
    }
}
