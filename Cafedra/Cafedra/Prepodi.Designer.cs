namespace Cafedra
{
    partial class Prepodi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prepodi_1 = new Cafedra.prepodi_1();
            this.prepodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepodTableAdapter = new Cafedra.prepodi_1TableAdapters.PrepodTableAdapter();
            this.idprepodovatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcafedriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prepod = new System.Windows.Forms.TextBox();
            this.id_caf = new System.Windows.Forms.TextBox();
            this.familia = new System.Windows.Forms.TextBox();
            this.imya = new System.Windows.Forms.TextBox();
            this.otchestvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dobavit = new System.Windows.Forms.Button();
            this.izmenenie = new System.Windows.Forms.Button();
            this.udalenie = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodi_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprepodovatelyaDataGridViewTextBoxColumn,
            this.idcafedriDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prepodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(124, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // prepodi_1
            // 
            this.prepodi_1.DataSetName = "prepodi_1";
            this.prepodi_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepodBindingSource
            // 
            this.prepodBindingSource.DataMember = "Prepod";
            this.prepodBindingSource.DataSource = this.prepodi_1;
            // 
            // prepodTableAdapter
            // 
            this.prepodTableAdapter.ClearBeforeFill = true;
            // 
            // idprepodovatelyaDataGridViewTextBoxColumn
            // 
            this.idprepodovatelyaDataGridViewTextBoxColumn.DataPropertyName = "id_prepodovatelya";
            this.idprepodovatelyaDataGridViewTextBoxColumn.HeaderText = "id_prepodovatelya";
            this.idprepodovatelyaDataGridViewTextBoxColumn.Name = "idprepodovatelyaDataGridViewTextBoxColumn";
            this.idprepodovatelyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcafedriDataGridViewTextBoxColumn
            // 
            this.idcafedriDataGridViewTextBoxColumn.DataPropertyName = "id_cafedri";
            this.idcafedriDataGridViewTextBoxColumn.HeaderText = "id_cafedri";
            this.idcafedriDataGridViewTextBoxColumn.Name = "idcafedriDataGridViewTextBoxColumn";
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "imya";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // id_prepod
            // 
            this.id_prepod.Location = new System.Drawing.Point(114, 205);
            this.id_prepod.Name = "id_prepod";
            this.id_prepod.Size = new System.Drawing.Size(100, 20);
            this.id_prepod.TabIndex = 2;
            // 
            // id_caf
            // 
            this.id_caf.Location = new System.Drawing.Point(231, 205);
            this.id_caf.Name = "id_caf";
            this.id_caf.Size = new System.Drawing.Size(100, 20);
            this.id_caf.TabIndex = 3;
            // 
            // familia
            // 
            this.familia.Location = new System.Drawing.Point(350, 205);
            this.familia.Name = "familia";
            this.familia.Size = new System.Drawing.Size(100, 20);
            this.familia.TabIndex = 4;
            // 
            // imya
            // 
            this.imya.Location = new System.Drawing.Point(469, 205);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(100, 20);
            this.imya.TabIndex = 5;
            // 
            // otchestvo
            // 
            this.otchestvo.Location = new System.Drawing.Point(586, 205);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(100, 20);
            this.otchestvo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id_преподователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "id_кафедры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчество";
            // 
            // dobavit
            // 
            this.dobavit.Location = new System.Drawing.Point(223, 285);
            this.dobavit.Name = "dobavit";
            this.dobavit.Size = new System.Drawing.Size(117, 34);
            this.dobavit.TabIndex = 12;
            this.dobavit.Text = "Добавление";
            this.dobavit.UseVisualStyleBackColor = true;
            this.dobavit.Click += new System.EventHandler(this.dobavit_Click);
            // 
            // izmenenie
            // 
            this.izmenenie.Location = new System.Drawing.Point(346, 285);
            this.izmenenie.Name = "izmenenie";
            this.izmenenie.Size = new System.Drawing.Size(117, 34);
            this.izmenenie.TabIndex = 13;
            this.izmenenie.Text = "Изменение";
            this.izmenenie.UseVisualStyleBackColor = true;
            this.izmenenie.Click += new System.EventHandler(this.izmenenie_Click);
            // 
            // udalenie
            // 
            this.udalenie.Location = new System.Drawing.Point(469, 285);
            this.udalenie.Name = "udalenie";
            this.udalenie.Size = new System.Drawing.Size(117, 34);
            this.udalenie.TabIndex = 14;
            this.udalenie.Text = "Удаление";
            this.udalenie.UseVisualStyleBackColor = true;
            this.udalenie.Click += new System.EventHandler(this.udalenie_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(13, 415);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 16;
            this.print.Text = "Печать";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Prepodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.back);
            this.Controls.Add(this.udalenie);
            this.Controls.Add(this.izmenenie);
            this.Controls.Add(this.dobavit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.imya);
            this.Controls.Add(this.familia);
            this.Controls.Add(this.id_caf);
            this.Controls.Add(this.id_prepod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prepodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepodi";
            this.Load += new System.EventHandler(this.Prepodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodi_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private prepodi_1 prepodi_1;
        private System.Windows.Forms.BindingSource prepodBindingSource;
        private prepodi_1TableAdapters.PrepodTableAdapter prepodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprepodovatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcafedriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id_prepod;
        private System.Windows.Forms.TextBox id_caf;
        private System.Windows.Forms.TextBox familia;
        private System.Windows.Forms.TextBox imya;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dobavit;
        private System.Windows.Forms.Button izmenenie;
        private System.Windows.Forms.Button udalenie;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button print;
    }
}