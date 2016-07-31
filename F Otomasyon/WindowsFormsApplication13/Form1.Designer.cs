namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ilk_veritabaniDataSet = new WindowsFormsApplication13.bin.Debug.ilk_veritabaniDataSet();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturalarTableAdapter = new WindowsFormsApplication13.bin.Debug.ilk_veritabaniDataSetTableAdapters.FaturalarTableAdapter();
            this.faturaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurDegeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaKalemAdetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk_veritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaIDDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.kurDegeriDataGridViewTextBoxColumn,
            this.faturaKalemAdetiDataGridViewTextBoxColumn,
            this.malzemeIDDataGridViewTextBoxColumn,
            this.firmaIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FaturaID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FaturaNo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FaturaTarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "KurDegeri : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FaturaKalemAdeti : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "MalzemeID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "FirmaID : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(105, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 194);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ilk_veritabaniDataSet
            // 
            this.ilk_veritabaniDataSet.DataSetName = "ilk_veritabaniDataSet";
            this.ilk_veritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "Faturalar";
            this.faturalarBindingSource.DataSource = this.ilk_veritabaniDataSet;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // faturaIDDataGridViewTextBoxColumn
            // 
            this.faturaIDDataGridViewTextBoxColumn.DataPropertyName = "FaturaID";
            this.faturaIDDataGridViewTextBoxColumn.HeaderText = "FaturaID";
            this.faturaIDDataGridViewTextBoxColumn.Name = "faturaIDDataGridViewTextBoxColumn";
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            // 
            // kurDegeriDataGridViewTextBoxColumn
            // 
            this.kurDegeriDataGridViewTextBoxColumn.DataPropertyName = "KurDegeri";
            this.kurDegeriDataGridViewTextBoxColumn.HeaderText = "KurDegeri";
            this.kurDegeriDataGridViewTextBoxColumn.Name = "kurDegeriDataGridViewTextBoxColumn";
            // 
            // faturaKalemAdetiDataGridViewTextBoxColumn
            // 
            this.faturaKalemAdetiDataGridViewTextBoxColumn.DataPropertyName = "FaturaKalemAdeti";
            this.faturaKalemAdetiDataGridViewTextBoxColumn.HeaderText = "FaturaKalemAdeti";
            this.faturaKalemAdetiDataGridViewTextBoxColumn.Name = "faturaKalemAdetiDataGridViewTextBoxColumn";
            // 
            // malzemeIDDataGridViewTextBoxColumn
            // 
            this.malzemeIDDataGridViewTextBoxColumn.DataPropertyName = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.HeaderText = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.Name = "malzemeIDDataGridViewTextBoxColumn";
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Arama";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aranacak FaturaID : ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(343, 135);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(343, 181);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Silinecek FaturaID : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 361);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilk_veritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private bin.Debug.ilk_veritabaniDataSet ilk_veritabaniDataSet;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private bin.Debug.ilk_veritabaniDataSetTableAdapters.FaturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurDegeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaKalemAdetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
    }
}

