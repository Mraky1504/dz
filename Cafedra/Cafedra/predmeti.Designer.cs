namespace Cafedra
{
    partial class Predmeti
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
            this.predmeti_1 = new Cafedra.predmeti_1();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetTableAdapter = new Cafedra.predmeti_1TableAdapters.PredmetTableAdapter();
            this.idpredmetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_predmeta = new System.Windows.Forms.TextBox();
            this.predmet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.udalenie = new System.Windows.Forms.Button();
            this.izmenenie = new System.Windows.Forms.Button();
            this.dobavit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmeti_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpredmetaDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(274, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // predmeti_1
            // 
            this.predmeti_1.DataSetName = "predmeti_1";
            this.predmeti_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.predmeti_1;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // idpredmetaDataGridViewTextBoxColumn
            // 
            this.idpredmetaDataGridViewTextBoxColumn.DataPropertyName = "id_predmeta";
            this.idpredmetaDataGridViewTextBoxColumn.HeaderText = "id_predmeta";
            this.idpredmetaDataGridViewTextBoxColumn.Name = "idpredmetaDataGridViewTextBoxColumn";
            this.idpredmetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            // 
            // id_predmeta
            // 
            this.id_predmeta.Location = new System.Drawing.Point(274, 212);
            this.id_predmeta.Name = "id_predmeta";
            this.id_predmeta.Size = new System.Drawing.Size(100, 20);
            this.id_predmeta.TabIndex = 1;
            // 
            // predmet
            // 
            this.predmet.Location = new System.Drawing.Point(420, 212);
            this.predmet.Name = "predmet";
            this.predmet.Size = new System.Drawing.Size(100, 20);
            this.predmet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id_предмета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "предмет";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 19;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // udalenie
            // 
            this.udalenie.Location = new System.Drawing.Point(469, 285);
            this.udalenie.Name = "udalenie";
            this.udalenie.Size = new System.Drawing.Size(117, 34);
            this.udalenie.TabIndex = 18;
            this.udalenie.Text = "Удаление";
            this.udalenie.UseVisualStyleBackColor = true;
            this.udalenie.Click += new System.EventHandler(this.udalenie_Click);
            // 
            // izmenenie
            // 
            this.izmenenie.Location = new System.Drawing.Point(346, 285);
            this.izmenenie.Name = "izmenenie";
            this.izmenenie.Size = new System.Drawing.Size(117, 34);
            this.izmenenie.TabIndex = 17;
            this.izmenenie.Text = "Изменение";
            this.izmenenie.UseVisualStyleBackColor = true;
            this.izmenenie.Click += new System.EventHandler(this.izmenenie_Click);
            // 
            // dobavit
            // 
            this.dobavit.Location = new System.Drawing.Point(223, 285);
            this.dobavit.Name = "dobavit";
            this.dobavit.Size = new System.Drawing.Size(117, 34);
            this.dobavit.TabIndex = 16;
            this.dobavit.Text = "Добавление";
            this.dobavit.UseVisualStyleBackColor = true;
            this.dobavit.Click += new System.EventHandler(this.dobavit_Click);
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.udalenie);
            this.Controls.Add(this.izmenenie);
            this.Controls.Add(this.dobavit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmet);
            this.Controls.Add(this.id_predmeta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Predmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.Predmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmeti_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private predmeti_1 predmeti_1;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private predmeti_1TableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpredmetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id_predmeta;
        private System.Windows.Forms.TextBox predmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button udalenie;
        private System.Windows.Forms.Button izmenenie;
        private System.Windows.Forms.Button dobavit;
    }
}