using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileDataAccessDemo;

namespace TextFileDataAccessGUIDemo
{
    public partial class frmPeople : Form
    {
        List<Person> people = new List<Person>();

        string txtFileName;
        string fileLocation;

        // Used to connect the List<Car> lists in Store to the ListBox form controls on the form
        BindingSource listBinding = new BindingSource();

        public frmPeople()
        {
            InitializeComponent();

            // Set Properties for Open File Dialog control
            openFileDialog.InitialDirectory = Application.StartupPath + "..\\..\\..\\..\\";
            // Set default & acceptable file extensions
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            SetListBindings();
        }


        /// <summary>
        /// Add a new Person to the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            // Create new Person and add to list
            people.Add(new Person(txtFirstName.Text, txtLastName.Text, txtURL.Text));

            // update List Box
            listBinding.ResetBindings(false);

            // clear text controls
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtURL.Text = string.Empty;
        }


        /// <summary>
        /// Save the current list to the PeopleOut.txt file by overriding the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Create an array of string lines to save
            string[] lines = new string[people.Count];
            int index = 0;

            // Declare & locate text file to update (same as we read from)
            foreach (Person person in people)
            {
                // get the ToString() of every person
                string updateLine = person.ToString();

                lines[index++] = updateLine;
            }

            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get file name/Location
                string saveFileLocation = Path.GetFullPath(this.saveFileDialog.FileName);

                // write on the text file
                File.WriteAllLines(saveFileLocation, lines);
            }
        }

        /// <summary>
        /// Add a existing List of Person instances to the current list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read filename selected
                txtFileName = this.openFileDialog.FileName;

                // Get file's path
                fileLocation = Path.GetFullPath(txtFileName);

                // Initialize list
                // Try-Catch statement to handle unexpected file exceptions
                try
                {
                    // Open file for reading
                    using (var str = File.OpenRead(fileLocation))
                    {
                        // Iterate through file text lines
                        foreach (string line in File.ReadLines(fileLocation))
                        {
                            string[] lines = line.Split(", ");

                            string first = lines[0];
                            string last = lines[1];
                            string url = lines[2];

                            // create and add Person object to list
                            people.Add(new Person(first, last, url));
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Display an error message
                    MessageBox.Show(ex.Message);
                }

                // Update list box
                //      Data type of the control has not changed, false
                listBinding.ResetBindings(false);
            }
        }

        /// <summary>
        /// Bind lists in Store with listbox controls in form
        /// </summary>
        private void SetListBindings()
        {
            // Binding Car inventory list
            listBinding.DataSource = people;
            lbPersonList.DataSource = listBinding;
            lbPersonList.DisplayMember = ToString();
        }
    }
}
