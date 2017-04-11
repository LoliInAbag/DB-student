namespace studentsDB
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eFDbContextDataSet = new studentsDB.EFDbContextDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new studentsDB.EFDbContextDataSetTableAdapters.studentsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDbContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 60);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Location = new System.Drawing.Point(924, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(1277, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(1169, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "БД";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(1045, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.textBox31);
            this.EditPanel.Controls.Add(this.textBox30);
            this.EditPanel.Controls.Add(this.textBox29);
            this.EditPanel.Controls.Add(this.textBox28);
            this.EditPanel.Controls.Add(this.textBox27);
            this.EditPanel.Controls.Add(this.textBox26);
            this.EditPanel.Controls.Add(this.textBox25);
            this.EditPanel.Controls.Add(this.textBox24);
            this.EditPanel.Controls.Add(this.textBox23);
            this.EditPanel.Controls.Add(this.textBox22);
            this.EditPanel.Controls.Add(this.textBox21);
            this.EditPanel.Controls.Add(this.textBox20);
            this.EditPanel.Controls.Add(this.textBox19);
            this.EditPanel.Controls.Add(this.textBox18);
            this.EditPanel.Controls.Add(this.textBox17);
            this.EditPanel.Controls.Add(this.textBox16);
            this.EditPanel.Controls.Add(this.textBox15);
            this.EditPanel.Controls.Add(this.textBox14);
            this.EditPanel.Controls.Add(this.textBox13);
            this.EditPanel.Controls.Add(this.textBox12);
            this.EditPanel.Controls.Add(this.textBox11);
            this.EditPanel.Controls.Add(this.textBox10);
            this.EditPanel.Controls.Add(this.textBox9);
            this.EditPanel.Controls.Add(this.textBox8);
            this.EditPanel.Controls.Add(this.textBox7);
            this.EditPanel.Controls.Add(this.textBox6);
            this.EditPanel.Controls.Add(this.textBox5);
            this.EditPanel.Controls.Add(this.textBox4);
            this.EditPanel.Controls.Add(this.textBox3);
            this.EditPanel.Controls.Add(this.textBox2);
            this.EditPanel.Controls.Add(this.textBox1);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditPanel.Location = new System.Drawing.Point(0, 190);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1364, 338);
            this.EditPanel.TabIndex = 4;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(48, 70);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(158, 20);
            this.textBox31.TabIndex = 30;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(48, 48);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(158, 20);
            this.textBox30.TabIndex = 29;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(40, 40);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(158, 20);
            this.textBox29.TabIndex = 28;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(32, 32);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(158, 20);
            this.textBox28.TabIndex = 27;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(24, 24);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(158, 20);
            this.textBox27.TabIndex = 26;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(16, 16);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(158, 20);
            this.textBox26.TabIndex = 25;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(8, 8);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(158, 20);
            this.textBox25.TabIndex = 24;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(0, 0);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(158, 20);
            this.textBox24.TabIndex = 23;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(467, 304);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(158, 20);
            this.textBox23.TabIndex = 22;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(459, 296);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(158, 20);
            this.textBox22.TabIndex = 21;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(451, 288);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(158, 20);
            this.textBox21.TabIndex = 20;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(443, 280);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(158, 20);
            this.textBox20.TabIndex = 19;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(435, 272);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(158, 20);
            this.textBox19.TabIndex = 18;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(427, 264);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(158, 20);
            this.textBox18.TabIndex = 17;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(419, 256);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(158, 20);
            this.textBox17.TabIndex = 16;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(411, 248);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(158, 20);
            this.textBox16.TabIndex = 15;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(403, 240);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(158, 20);
            this.textBox15.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(395, 232);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(158, 20);
            this.textBox14.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(387, 224);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(158, 20);
            this.textBox13.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(379, 216);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(158, 20);
            this.textBox12.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(371, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(158, 20);
            this.textBox11.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(363, 200);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(158, 20);
            this.textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(355, 192);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(158, 20);
            this.textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(347, 184);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(64, 224);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(158, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(64, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(64, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // eFDbContextDataSet
            // 
            this.eFDbContextDataSet.DataSetName = "EFDbContextDataSet";
            this.eFDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.eFDbContextDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDbContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private EFDbContextDataSet eFDbContextDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EFDbContextDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
    }
}

