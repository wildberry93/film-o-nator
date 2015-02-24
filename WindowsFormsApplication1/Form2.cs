using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        static int id = 0;
        private string[] colnameList = new string[] { "ID", "EN", "PL", "KATEGORIA", "ROK", "OPINIA", "INNE" };
        DataTable global_data = new DataTable();  
        Form1 form1;
       


        public Form2()
        {
            InitializeComponent();
            string path;
            path = open_dialog();
            global_data = getTable(path);
            dataGridView1.DataSource = global_data;
            this.Show();
        }

        private string open_dialog()
        {
            string file;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
               file = openFileDialog1.FileName;
               return file;
            }
            else
            {
                return "C:\\Users\\Jagoda\\Desktop\\plik1.csv";
            }
            
        }

        private List<string[]> readCSV(string file_path)
        {
            List<string[]> load_values = new List<string[]>();
            TextFieldParser csvReader = new TextFieldParser(file_path);
            csvReader.SetDelimiters(new string[] { "," });
            csvReader.HasFieldsEnclosedInQuotes = true;
            while (!csvReader.EndOfData)
            {
                string[] fieldData = csvReader.ReadFields();
                load_values.Add(fieldData);
            }
            return load_values;
        }


        private DataTable getTable(string path)
        {
            DataTable newTable = new DataTable();
            List<string[]> fileParse = readCSV(path);

            foreach (string colname in colnameList) newTable.Columns.Add(colname);


            foreach (string[] row in fileParse)
            {
                string[] elements = new string[7];
                for (int j = 0; j < row.Length; j++) elements[j + 1] = row[j];
                if (elements[1] != "")
                {
                    id++;
                    elements[0] = id.ToString();
                    newTable.Rows.Add(elements);
                }
            }

            id = 0;
            return newTable;
        }

        //Dodajemy film z form1
        public void add_film(List<string> new_film, int rowNumb)
        {
            DataRow new_row = global_data.NewRow();
            new_row[0] = new_film[0];
            new_row[1] = new_film[1];
            new_row[2] = new_film[2];
            new_row[3] = new_film[3];
            new_row[4] = new_film[4];
            new_row[5] = new_film[5];
            new_row[6] = new_film[6];
            global_data.Rows.InsertAt(new_row,rowNumb);

            if (rowNumb + 1 != global_data.Rows.Count)
            {
                global_data.Rows[rowNumb + 1].Delete();

            }
        }

        // Przenumerowanie
        public void renumber_ids()
        {
            int cnt = 1;
            foreach (DataRow row in global_data.Rows)
            {
                row[0] = cnt;
                cnt++;
            }
        }

        // Zapisujemy filmy
        private void save_films()
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = global_data.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in global_data.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            System.IO.File.WriteAllText("C:\\Users\\Jagoda\\Desktop\\filmy.csv", sb.ToString());
        }


        //Aktualizacja kategorii po edycji
        public void update_table(List<string>to_update)
        {
            DataTable dtUpdated = new DataTable();
            dtUpdated = global_data.Clone();
            foreach(DataRow dr in global_data.Rows)
            {
                if (dr[3].ToString() == to_update[0])
                {
                    dr[3] = to_update[1];
                }
                dtUpdated.ImportRow(dr); 
            }
            global_data = dtUpdated;

        }


        // Klikamy!
        private void button4_Click(object sender, EventArgs e) //dodaj
        {
            int rowNumber = dataGridView1.Rows.Count;
            List<string> fake_list = Enumerable.Repeat("", 7).ToList();
            form1 = new Form1(this, rowNumber, fake_list);
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)  // usun
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            renumber_ids();
        }

        private void button2_Click(object sender, EventArgs e) //edytuj
        {
            List<string> true_list = new List<string>();
            int which_row = dataGridView1.SelectedCells[0].RowIndex;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                true_list.Add((string)dataGridView1.Rows[which_row].Cells[j].Value);

            form1 = new Form1(this, which_row, true_list);
            form1.Show();
        }


        //odpalamy staty
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            calculate_stats();
        }

        // Liczyymy staty
        private void calculate_stats()
        {
            //3 i 4 kolumna
            List<string> categories = new List<string>();
            List<string> years = new List<string>();
            Dictionary<string, int> yrs_dict = new Dictionary<string, int>();
            Dictionary<string, int> cats_dict = new Dictionary<string, int>();

            foreach(DataRow dr in global_data.Rows)
            {
                categories.Add(dr[3].ToString());
                years.Add(dr[4].ToString());

            }

            List<string>cats_old = new List<string>();
            List<string> yrs_old = new List<string>();
            cats_old = categories;
            yrs_old = years;

            categories = categories.Distinct().ToList();
            years = years.Distinct().ToList();


            for (int i = 0; i < years.Count; i++)
            {
                yrs_dict.Add(years[i], 0);

            }

            for (int i = 0; i < categories.Count; i++)
            {
                cats_dict.Add(categories[i], 0);

            }

                // iterujemy przez slownik

                foreach (string yr in years)
                {
                    for (int i = 0; i < yrs_old.Count; i++)
                    {
                        if (yr == yrs_old[i])
                        {
                            yrs_dict[yr] = yrs_dict[yr] + 1;
                        }
                    }
                }


            foreach (string cats in categories)
            {
                for (int i = 0; i < cats_old.Count; i++)
                {
                    if (cats == cats_old[i])
                    {
                        cats_dict[cats] = cats_dict[cats] + 1;
                    }
                }
            }

            stats.AppendText("Statystyki - lata \n");
            //wyswietlamy
            foreach (KeyValuePair<string, int> kv in yrs_dict)
            {
                stats.AppendText(kv.Key.ToString()+"   "+kv.Value.ToString());
                stats.AppendText("\n");

            }

            stats.AppendText("\n");
            stats.AppendText("Statystyki - kategorie \n");
            foreach (KeyValuePair<string, int> kv in cats_dict)
            {
                stats.AppendText(kv.Key.ToString()+"   "+kv.Value.ToString());
                stats.AppendText("\n");

            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Dziękujemy za skorzystanie z naszego programu!");
            save_films();
        }

  

    }
}
