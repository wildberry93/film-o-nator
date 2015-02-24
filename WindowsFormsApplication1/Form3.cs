using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Form2 frm2;
        List<string> cats = new List<string>();
        public Form3(Form2 fr2, List<string>categories)
        {
            InitializeComponent();
            frm2 = fr2;
            cats = categories;
            combine_combo(cats);

        }
        private void combine_combo(List<string> combo_cat)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            int cnt = 1;
            foreach (string cat in combo_cat) { comboSource.Add(cnt, cat); cnt++; }
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";

        }

        private void dodaj_kat_Click(object sender, EventArgs e)
        {
            List<string>new_cat_list = new List<string>();
            new_cat_list = cats;
            if(new_kat_nam.Text != "")
            {
                new_cat_list.Add(new_kat_nam.Text);
            }
            new_kat_nam.Text = String.Empty; 
            combine_combo(new_cat_list);
            save_cats_to_file(new_cat_list);
        }

        private void usun_kat_Click(object sender, EventArgs e)
        {
            List<string> old_cat_list = new List<string>();
            List<string> new_cat_list = new List<string>();
            List<string> to_remove_from_dt = new List<string>();

            old_cat_list = cats;
            int del_id = 0;
            del_id = comboBox1.SelectedIndex;
            for (int i = 0; i < old_cat_list.Count; i++)
            {
                if (i != del_id) { new_cat_list.Add(old_cat_list[i]); }
            }

            to_remove_from_dt.Add(old_cat_list[del_id]);
            to_remove_from_dt.Add("");

            frm2.update_table(to_remove_from_dt);
            combine_combo(new_cat_list);
            save_cats_to_file(new_cat_list);

        }


        private void edit_kat_Click(object sender, EventArgs e)
        {
            List<string> old_cat_list = new List<string>();
            List<string> edited = new List<string>();
            old_cat_list = cats;
            int sel_ind = 0;
            sel_ind = comboBox1.SelectedIndex;
            edited.Add(old_cat_list[sel_ind]);
            old_cat_list[sel_ind] = new_kat_nam.Text;
            edited.Add(new_kat_nam.Text);
            new_kat_nam.Text = String.Empty; 
            frm2.update_table(edited);
            combine_combo(old_cat_list);
            save_cats_to_file(old_cat_list);
        }

        private void save_cats_to_file(List<string>cats)
        {
            string fileName = "C:\\Users\\Jagoda\\Desktop\\kategorie.txt";
            System.IO.File.WriteAllLines(fileName, cats, Encoding.UTF8);

        }

    }
}
