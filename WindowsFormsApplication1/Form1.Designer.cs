namespace WindowsFormsApplication1
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
            this.pl_tit = new System.Windows.Forms.TextBox();
            this.eng_tit = new System.Windows.Forms.TextBox();
            this.others = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.opinion = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pl_tit
            // 
            this.pl_tit.Location = new System.Drawing.Point(64, 69);
            this.pl_tit.Name = "pl_tit";
            this.pl_tit.Size = new System.Drawing.Size(268, 22);
            this.pl_tit.TabIndex = 0;
            // 
            // eng_tit
            // 
            this.eng_tit.Location = new System.Drawing.Point(64, 138);
            this.eng_tit.Name = "eng_tit";
            this.eng_tit.Size = new System.Drawing.Size(268, 22);
            this.eng_tit.TabIndex = 1;
            // 
            // others
            // 
            this.others.Location = new System.Drawing.Point(64, 441);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(268, 22);
            this.others.TabIndex = 2;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(64, 212);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(268, 22);
            this.year.TabIndex = 3;
            // 
            // opinion
            // 
            this.opinion.Location = new System.Drawing.Point(64, 284);
            this.opinion.Name = "opinion";
            this.opinion.Size = new System.Drawing.Size(268, 22);
            this.opinion.TabIndex = 4;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(64, 360);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(268, 24);
            this.category.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tytuł PL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tytuł ENG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opinia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inne?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rok produkcji";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OK_button.Location = new System.Drawing.Point(449, 73);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(225, 117);
            this.OK_button.TabIndex = 13;
            this.OK_button.Text = "OK!";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(476, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edytuj Kategorie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.opinion);
            this.Controls.Add(this.year);
            this.Controls.Add(this.others);
            this.Controls.Add(this.eng_tit);
            this.Controls.Add(this.pl_tit);
            this.Name = "Form1";
            this.Text = "Dodaj/edytuj film";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pl_tit;
        private System.Windows.Forms.TextBox eng_tit;
        private System.Windows.Forms.TextBox others;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox opinion;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button button1;
    }
}

