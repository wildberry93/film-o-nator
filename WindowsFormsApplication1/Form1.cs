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
    public partial class Form1 : Form
    {
        List<string> list_of_columns = new List<string>();
        string cats_path = "C:\\Users\\Jagoda\\Desktop\\kategorie.txt";
        List<string> cats = new List<string>();

        int rowNumber = 0;
        Form2 fr2;
        Form3 fr3;

        public Form1(Form2 form2, int rowNumb, List<string> list_of_values)
        {
            InitializeComponent();
            pl_tit.Text = list_of_values[2];
            eng_tit.Text = list_of_values[1];
            year.Text = list_of_values[4];
            category.Text = list_of_values[2];
            opinion.Text = list_of_values[5];
            others.Text = list_of_values[6];
            rowNumber = rowNumb;
            fr2 = form2;
            cats = get_categories();

            combine_combo(cats);

        }

        private void OK_button_Click(object sender, EventArgs e)  //dodajemy!
        {
            if (eng_tit.Text == "")
            {
                MessageBox.Show("Podaj tytuł w języku angielskim!");
            }
            List<string> new_film = new List<string>(); // lista zamiast string!
            new_film.Add(Convert.ToString(rowNumber));
            new_film.Add(eng_tit.Text);
            new_film.Add(pl_tit.Text);
            new_film.Add(category.Text);
            new_film.Add(year.Text);
            new_film.Add(opinion.Text);
            new_film.Add(others.Text);

            fr2.add_film(new_film, rowNumber);
            fr2.renumber_ids();
            fr2.Show();
            this.Close();
        }

        // Kleimy kombo
        private void combine_combo(List<string> combo_cat)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            int cnt = 1;
            foreach (string cat in combo_cat) { comboSource.Add(cnt, cat); cnt++; }
            category.DataSource = new BindingSource(comboSource, null);
            category.DisplayMember = "Value";

        }

        // Zapisujemy kategorie
        private void save_cats(List<string> cats)
        {
            string fileName = "Kategorie.txt";
            System.IO.File.WriteAllLines(fileName, cats, Encoding.UTF8);

        }

        // czytamy plik z kategoriami
        private List<string> get_categories()
        {
            List<string> cats = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(cats_path);
            string line;
            int counter = 0;

            while ((line = file.ReadLine()) != null)
            {
                cats.Add(line);
                counter++;
            }

            file.Close();

            return cats;
        }

        //klik edytuj kategorie
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cats = get_categories();
            Form3 form3 = new Form3(fr2,cats);
            form3.Show();

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_cats(cats);
        }



    }
}
