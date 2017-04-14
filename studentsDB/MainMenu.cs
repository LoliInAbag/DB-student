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
        
        
        int Id = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
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
            try
            {
                

                     if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                     SqlCommand sqlCmd = new SqlCommand("DeleteProcedure", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                   
                    sqlCmd.Parameters.AddWithValue("@Id", Id);                  
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Удалено");
                    Reset();
                    FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
               
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
               /* if (button5.Text == "Обновить")
               {*/
                    SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
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
              /*  }
               else
                {
                    SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id", "Id");
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
                    MessageBox.Show("неее");
                }*/
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
           // dataGridView1.Columns[0].Visible =false ;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                textBox13.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                textBox14.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                textBox15.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox16.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox17.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                textBox18.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                textBox19.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                textBox20.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textBox21.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                textBox22.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                textBox23.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                textBox24.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                textBox25.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                textBox26.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                textBox27.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
                textBox28.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                textBox29.Text = dataGridView1.CurrentRow.Cells[29].Value.ToString();
                textBox30.Text = dataGridView1.CurrentRow.Cells[30].Value.ToString(); 
                textBox31.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();   
             
                button5.Text = "Сохранить";
                button1.Enabled = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                    this.studentsTableAdapter.Update(this.eFDbContextDataSet.students);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet1.students". При необходимости она может быть перемещена или удалена.
                    this.studentsTableAdapter1.Update(this.eFDbContextDataSet1.students);
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id", "[Id]");
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
                    MessageBox.Show("Обновлено");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Обновлено");
            }
            finally
            {
                sqlCon.Close();
            }
                       
        }
        void Reset()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = textBox19.Text = textBox20.Text = textBox21.Text = textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text = textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text = textBox31.Text = "";
            button5.Text = "Сохранить";
            Id = 0;
            button1.Enabled = false;

            }

        private void button9_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
