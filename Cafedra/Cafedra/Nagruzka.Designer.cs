namespace Cafedra
{
    partial class Nagruzka
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
            this.idprepodovatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpredmetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnagruzkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidnagruzkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagruzkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nagruzka_1 = new Cafedra.nagruzka_1();
            this.nagruzkaTableAdapter = new Cafedra.nagruzka_1TableAdapters.NagruzkaTableAdapter();
            this.id_prepod = new System.Windows.Forms.TextBox();
            this.id_predmeta = new System.Windows.Forms.TextBox();
            this.id_nagruzki = new System.Windows.Forms.TextBox();
            this.vid_nagruzki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.udalenie = new System.Windows.Forms.Button();
            this.izmenenie = new System.Windows.Forms.Button();
            this.dobavit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzka_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprepodovatelyaDataGridViewTextBoxColumn,
            this.idpredmetaDataGridViewTextBoxColumn,
            this.idnagruzkiDataGridViewTextBoxColumn,
            this.vidnagruzkiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nagruzkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(176, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idprepodovatelyaDataGridViewTextBoxColumn
            // 
            this.idprepodovatelyaDataGridViewTextBoxColumn.DataPropertyName = "id_prepodovatelya";
            this.idprepodovatelyaDataGridViewTextBoxColumn.HeaderText = "id_prepodovatelya";
            this.idprepodovatelyaDataGridViewTextBoxColumn.Name = "idprepodovatelyaDataGridViewTextBoxColumn";
            // 
            // idpredmetaDataGridViewTextBoxColumn
            // 
            this.idpredmetaDataGridViewTextBoxColumn.DataPropertyName = "id_predmeta";
            this.idpredmetaDataGridViewTextBoxColumn.HeaderText = "id_predmeta";
            this.idpredmetaDataGridViewTextBoxColumn.Name = "idpredmetaDataGridViewTextBoxColumn";
            // 
            // idnagruzkiDataGridViewTextBoxColumn
            // 
            this.idnagruzkiDataGridViewTextBoxColumn.DataPropertyName = "id_nagruzki";
            this.idnagruzkiDataGridViewTextBoxColumn.HeaderText = "id_nagruzki";
            this.idnagruzkiDataGridViewTextBoxColumn.Name = "idnagruzkiDataGridViewTextBoxColumn";
            this.idnagruzkiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vidnagruzkiDataGridViewTextBoxColumn
            // 
            this.vidnagruzkiDataGridViewTextBoxColumn.DataPropertyName = "vid_nagruzki";
            this.vidnagruzkiDataGridViewTextBoxColumn.HeaderText = "vid_nagruzki";
            this.vidnagruzkiDataGridViewTextBoxColumn.Name = "vidnagruzkiDataGridViewTextBoxColumn";
            // 
            // nagruzkaBindingSource
            // 
            this.nagruzkaBindingSource.DataMember = "Nagruzka";
            this.nagruzkaBindingSource.DataSource = this.nagruzka_1;
            // 
            // nagruzka_1
            // 
            this.nagruzka_1.DataSetName = "nagruzka_1";
            this.nagruzka_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nagruzkaTableAdapter
            // 
            this.nagruzkaTableAdapter.ClearBeforeFill = true;
            // 
            // id_prepod
            // 
            this.id_prepod.Location = new System.Drawing.Point(166, 205);
            this.id_prepod.Name = "id_prepod";
            this.id_prepod.Size = new System.Drawing.Size(100, 20);
            this.id_prepod.TabIndex = 1;
            // 
            // id_predmeta
            // 
            this.id_predmeta.Location = new System.Drawing.Point(296, 205);
            this.id_predmeta.Name = "id_predmeta";
            this.id_predmeta.Size = new System.Drawing.Size(100, 20);
            this.id_predmeta.TabIndex = 2;
            // 
            // id_nagruzki
            // 
            this.id_nagruzki.Location = new System.Drawing.Point(418, 205);
            this.id_nagruzki.Name = "id_nagruzki";
            this.id_nagruzki.Size = new System.Drawing.Size(100, 20);
            this.id_nagruzki.TabIndex = 3;
            // 
            // vid_nagruzki
            // 
            this.vid_nagruzki.Location = new System.Drawing.Point(533, 205);
            this.vid_nagruzki.Name = "vid_nagruzki";
            this.vid_nagruzki.Size = new System.Drawing.Size(100, 20);
            this.vid_nagruzki.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id_преподователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "id_предмета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "id_нагрузки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вид Нагрузки";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 23;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // udalenie
            // 
            this.udalenie.Location = new System.Drawing.Point(469, 285);
            this.udalenie.Name = "udalenie";
            this.udalenie.Size = new System.Drawing.Size(117, 34);
            this.udalenie.TabIndex = 22;
            this.udalenie.Text = "Удаление";
            this.udalenie.UseVisualStyleBackColor = true;
            this.udalenie.Click += new System.EventHandler(this.udalenie_Click);
            // 
            // izmenenie
            // 
            this.izmenenie.Location = new System.Drawing.Point(346, 285);
            this.izmenenie.Name = "izmenenie";
            this.izmenenie.Size = new System.Drawing.Size(117, 34);
            this.izmenenie.TabIndex = 21;
            this.izmenenie.Text = "Изменение";
            this.izmenenie.UseVisualStyleBackColor = true;
            this.izmenenie.Click += new System.EventHandler(this.izmenenie_Click);
            // 
            // dobavit
            // 
            this.dobavit.Location = new System.Drawing.Point(223, 285);
            this.dobavit.Name = "dobavit";
            this.dobavit.Size = new System.Drawing.Size(117, 34);
            this.dobavit.TabIndex = 20;
            this.dobavit.Text = "Добавление";
            this.dobavit.UseVisualStyleBackColor = true;
            this.dobavit.Click += new System.EventHandler(this.dobavit_Click);
            // 
            // Nagruzka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.udalenie);
            this.Controls.Add(this.izmenenie);
            this.Controls.Add(this.dobavit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vid_nagruzki);
            this.Controls.Add(this.id_nagruzki);
            this.Controls.Add(this.id_predmeta);
            this.Controls.Add(this.id_prepod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nagruzka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nagruzka";
            this.Load += new System.EventHandler(this.Nagruzka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzka_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private nagruzka_1 nagruzka_1;
        private System.Windows.Forms.BindingSource nagruzkaBindingSource;
        private nagruzka_1TableAdapters.NagruzkaTableAdapter nagruzkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprepodovatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpredmetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnagruzkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidnagruzkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id_prepod;
        private System.Windows.Forms.TextBox id_predmeta;
        private System.Windows.Forms.TextBox id_nagruzki;
        private System.Windows.Forms.TextBox vid_nagruzki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button udalenie;
        private System.Windows.Forms.Button izmenenie;
        private System.Windows.Forms.Button dobavit;
    }
}