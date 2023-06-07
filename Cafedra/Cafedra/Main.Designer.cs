namespace Cafedra
{
    partial class Main
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
            this.prepod = new System.Windows.Forms.Button();
            this.predmeti = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.nagruzka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prepod
            // 
            this.prepod.Location = new System.Drawing.Point(329, 107);
            this.prepod.Name = "prepod";
            this.prepod.Size = new System.Drawing.Size(136, 67);
            this.prepod.TabIndex = 0;
            this.prepod.Text = "Преподователи";
            this.prepod.UseVisualStyleBackColor = true;
            this.prepod.Click += new System.EventHandler(this.prepod_Click);
            // 
            // predmeti
            // 
            this.predmeti.Location = new System.Drawing.Point(329, 192);
            this.predmeti.Name = "predmeti";
            this.predmeti.Size = new System.Drawing.Size(136, 67);
            this.predmeti.TabIndex = 1;
            this.predmeti.Text = "Предметы";
            this.predmeti.UseVisualStyleBackColor = true;
            this.predmeti.Click += new System.EventHandler(this.predmeti_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nagruzka
            // 
            this.nagruzka.Location = new System.Drawing.Point(329, 275);
            this.nagruzka.Name = "nagruzka";
            this.nagruzka.Size = new System.Drawing.Size(136, 67);
            this.nagruzka.TabIndex = 3;
            this.nagruzka.Text = "Нагрузка";
            this.nagruzka.UseVisualStyleBackColor = true;
            this.nagruzka.Click += new System.EventHandler(this.nagruzka_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nagruzka);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.predmeti);
            this.Controls.Add(this.prepod);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prepod;
        private System.Windows.Forms.Button predmeti;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button nagruzka;
    }
}

