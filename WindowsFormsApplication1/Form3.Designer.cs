namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.edit_kat = new System.Windows.Forms.Button();
            this.usun_kat = new System.Windows.Forms.Button();
            this.dodaj_kat = new System.Windows.Forms.Button();
            this.new_kat_nam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // edit_kat
            // 
            this.edit_kat.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_kat.Location = new System.Drawing.Point(540, 192);
            this.edit_kat.Name = "edit_kat";
            this.edit_kat.Size = new System.Drawing.Size(175, 95);
            this.edit_kat.TabIndex = 3;
            this.edit_kat.Text = "Edytuj";
            this.edit_kat.UseVisualStyleBackColor = true;
            this.edit_kat.Click += new System.EventHandler(this.edit_kat_Click);
            // 
            // usun_kat
            // 
            this.usun_kat.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun_kat.Location = new System.Drawing.Point(540, 333);
            this.usun_kat.Name = "usun_kat";
            this.usun_kat.Size = new System.Drawing.Size(175, 90);
            this.usun_kat.TabIndex = 4;
            this.usun_kat.Text = "Usuń";
            this.usun_kat.UseVisualStyleBackColor = true;
            this.usun_kat.Click += new System.EventHandler(this.usun_kat_Click);
            // 
            // dodaj_kat
            // 
            this.dodaj_kat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_kat.Location = new System.Drawing.Point(540, 55);
            this.dodaj_kat.Name = "dodaj_kat";
            this.dodaj_kat.Size = new System.Drawing.Size(175, 92);
            this.dodaj_kat.TabIndex = 5;
            this.dodaj_kat.Text = "Dodaj";
            this.dodaj_kat.UseVisualStyleBackColor = true;
            this.dodaj_kat.Click += new System.EventHandler(this.dodaj_kat_Click);
            // 
            // new_kat_nam
            // 
            this.new_kat_nam.Location = new System.Drawing.Point(322, 172);
            this.new_kat_nam.Name = "new_kat_nam";
            this.new_kat_nam.Size = new System.Drawing.Size(160, 22);
            this.new_kat_nam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nowa nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wybierz kategorię";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.star_wars_minions;
            this.ClientSize = new System.Drawing.Size(824, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_kat_nam);
            this.Controls.Add(this.dodaj_kat);
            this.Controls.Add(this.usun_kat);
            this.Controls.Add(this.edit_kat);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Edycja kategorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button edit_kat;
        private System.Windows.Forms.Button usun_kat;
        private System.Windows.Forms.Button dodaj_kat;
        private System.Windows.Forms.TextBox new_kat_nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}