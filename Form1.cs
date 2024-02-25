using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace L1_13.Arsenii.Ziubin
{
    public partial class Form1 : Form
    {
        // Header element
        string moduleName;
        // Container object for student initial data
        ArrayOfPostCards Collectors;
        ArrayOfPostCards Collectors1;
        // Container object (results)
        ArrayOfPostCards ResultContainer;
        private ArrayOfPostCards CopiedResultContainer;
        const string CFn = "NewPostcards.txt";
        // Chosen file names
        private string File1;

        public Form1()
        {
            
            InitializeComponent();
            ToggleControls();
            Collectors = new ArrayOfPostCards();
            Collectors1 = new ArrayOfPostCards();
            ResultContainer = new ArrayOfPostCards();
            Result.Items.Clear();
            ArrayOfPostCards postcardCollection = new ArrayOfPostCards();
            // new
            CopiedResultContainer = new ArrayOfPostCards();
        }

        /// <summary>
        /// Disable (enable) text input, Save menu and menu items for task execution
        /// </summary>
        private void ToggleControls(bool enabled = false)
        {
            //textBox.Enabled = enabled;
            ColPostcardsToolStripMenuItem.Enabled = enabled;
            collectorWithMoreThanOneCopyToolStripMenuItem.Enabled = enabled;
            sortByYearAscAlphToolStripMenuItem.Enabled = enabled;
            insertToContainerToolStripMenuItem.Enabled = enabled;
            removeUnknownYearToolStripMenuItem.Enabled = enabled;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method for reading initial data from .txt file to container Students
        /// </summary>
        /// <param name="filename">Name of the file</param>
        /// <param name="header">Header element i.e. name of the module</param>
        /// <param name="Students">Container of student data</param>
        private void ReadStudents(string filename, out string header, ArrayOfPostCards Collectors)
        {
            char[] delimiters = { ';', ' ' };
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = null;
                int i = 0;
                header = reader.ReadLine().Trim();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string NamePostCar = parts[0];
                    string Country = parts[1];
                    int Year = Convert.ToInt32(parts[2]);
                    string Type = parts[3];
                    int Height = Convert.ToInt32(parts[4]);
                    int Width = Convert.ToInt32(parts[5]);
                    int Quantity = Convert.ToInt32(parts[6]);
                    Collector s = new Collector( NamePostCar, Country, Year, Type, Height, Width, Quantity);
                    Collectors.Add(s);
                }
            }
        }
        /// <summary>
        /// Method for displaying student container Students data to screen using table format
        /// </summary>
        /// <param name="header">Header</param>
        /// <param name="LB">Listbox control</param>
        /// <param name="Students">Container of student data</param>
        private void DisplayStudentToGui(string header, ListBox LB, ArrayOfPostCards Collectors)
        {
            LB.Items.Add(header);
            LB.Items.Add("------------------------------------------------------");
            LB.Items.Add(" Name  Country  Year    Type   Height  Width  Quantity ");
            LB.Items.Add("------------------------------------------------------");
            for (int i = 0; i < Collectors.Count; i++)
            {
                Collector s = Collectors.Get(i);
                LB.Items.Add(s.ToString());
            }
            LB.Items.Add("------------------------------------------------------");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"; 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File1 = openFileDialog1.FileName;
                ReadStudents(File1, out moduleName, Collectors);

                ToggleControls(true);
                DisplayStudentToGui("Postcards from collector: " + moduleName, Result, Collectors);
            }
        }

        private void OpenFile2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File1 = openFileDialog1.FileName;
                ReadStudents(File1, out moduleName, Collectors1);

                ToggleControls(true);
                DisplayStudentToGui("Postcards from collector: " + moduleName, Result, Collectors1);
            }
        }

        private void ColPostcardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Items.Add("\n");
            string colloredPost = ColPostcards(Collectors, Collectors1);
            Result.Items.Add(colloredPost);
        }

        private string ColPostcards(ArrayOfPostCards Collector1Cards, ArrayOfPostCards Collector2Cards)
        {
            if (textBox1.Text.Trim() == "")
            {
                return "Please enter the name of the country.";
            }
            else
            {
                string countryName = textBox1.Text.Trim();
                int count1 = Collector1Cards.CountColoredPostcardsFromCountry(countryName);
                int count2 = Collector2Cards.CountColoredPostcardsFromCountry(countryName);

                if (count1 > count2)
                {
                    return $"Collector 1 has more colored postcards from {countryName}.";
                }
                else if (count2 > count1)
                {
                    return $"Collector 2 has more colored postcards from {countryName}.";
                }
                else
                    return $"collectors have same number of colored postcards from {countryName}.";
            }
        }

        private void collectorWithMoreThanOneCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Items.Add("\n");
            MoreThan1Copoy(Collectors, ref ResultContainer);
            MoreThan1Copoy(Collectors1, ref ResultContainer);
            
            DisplayStudentToGui("Postcards from ResultContainer: " + "ResultContainer", Result, ResultContainer);
        }

        private void MoreThan1Copoy(ArrayOfPostCards Collectors, ref ArrayOfPostCards ResultContainer)
        {
            for(int i = 0; i < Collectors.Count; i++)
            {
                if (Collectors.Get(i).Quantity > 1)
                {
                    ResultContainer.Add(Collectors.Get(i));
                }
            }
        }

        private void sortByYearAscAlphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Items.Add("\n");
            ResultContainer.Sort();
            DisplayStudentToGui("Sorted Postcards from ResultContainer: " + "ResultContainer", Result, ResultContainer);
        }

        private void removeUnknownYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result.Items.Add("\n");
            int count = 0;
            for (int i = 0; i < ResultContainer.Count; i++)
            {
                if(ResultContainer.Get(i).Year == 0)
                {
                    ResultContainer.RemoveAt(i);
                    count++;
                }
            }
            if(count == 0)
            {
                Result.Items.Add("There is no post cards with unknown year of issue");
            }
            else
                DisplayStudentToGui("Removed Postcards with unknown from ResultContainer: " + "ResultContainer", Result, ResultContainer);
        }

        private void insertToContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Result.Items.Add("\n");
            Insert(CFn);
            Result.Items.Add("Inserting was made");
        }

        private void Insert(string fv)
        {
            ArrayOfPostCards existingData = new ArrayOfPostCards();

            // Add new data to the existing data
            for (int i = 0; i < ResultContainer.Count; i++)
            {
                existingData.Insert(i, ResultContainer.Get(i));
            }

            // Write the combined data back to the file
            using (StreamWriter writer = new StreamWriter(fv))
            {
                writer.WriteLine(moduleName); // Write the header
                for (int i = 0; i < existingData.Count; i++)
                {
                    Collector collector = existingData.Get(i);
                    writer.WriteLine(collector.ToString()); // Using ToString() method
                }
            }
            
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
