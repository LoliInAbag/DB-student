using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentsDB
{
    public partial class MainMenu : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EFDbContext;Integrated Security=True");
        public MainMenu()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet1.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter1.Fill(this.eFDbContextDataSet1.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.eFDbContextDataSet.students);
          
            dataGridView1.Visible = false;
            EditPanel.Visible = false;
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            EditPanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "add");
                sqlCmd.Parameters.AddWithValue("@Id", "0");
                sqlCmd.Parameters.AddWithValue("@Фамилия", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Имя", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Отчество", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Группа", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Дата_рождения", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_поступления", textBox6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_окончания", textBox7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Образование", textBox8.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_окончания_школы", textBox9.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_школы", textBox10.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Специальность", textBox11.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Форма_обучения", textBox12.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_телефона_учащегося", textBox13.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_телефона_родителей", textBox14.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Адрес", textBox15.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Иностранный_язык", textBox16.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Группа_здоровья", textBox17.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Гражданство", textBox18.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Документ_подтверждающий_гражданство", textBox19.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Многодетная_семья", textBox20.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Инвалидность", textBox21.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Срок_действия", textBox22.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Основание_поощрение", textBox23.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Основание_взыскания", textBox24.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_диплома", textBox25.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@От_какого_числа", textBox26.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Внутриние_перемещения", textBox27.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Характеристика_выпускника", textBox28.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Трудоустройство_выпускника", textBox29.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Продвижение_выпускника", textBox30.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Пропуски_без_уважительных_причин", textBox31.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Сохранено");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewOrSearch",sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@lil",txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            sqlCon.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (this.txtSearch.Text != String.Empty)
            {
                this.studentsBindingSource1.Filter = String.Format("[Фамилия] LIKE '*{0}*' OR [Имя] LIKE '*{0}*' OR [Группа] LIKE '*{0}*'  OR [Специальность] LIKE '*{0}* 'OR [Иностранный_язык] LIKE '*{0}*' OR [Многодетная_семья] LIKE '*{0}*' OR [Номер_диплома] LIKE '*{0}*' OR [Форма_обучения ] LIKE '*{0}*' ", this.txtSearch.Text);
            }
            else
            {
                this.studentsBindingSource1.Filter = "";
            }*/
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            EditPanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            EditPanel.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
