using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HowTo_BindingList
{
    public partial class Form1 : Form
    {
        // Declare a BindingList
        BindingList<SomeObject> SomeObjects;

        public Form1()
        {
            InitializeComponent();
            // Instantiate BindingList
            SomeObjects = new BindingList<SomeObject>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add some data to BindingList
            AddDataToBindingList();
            UpdateCounts();
        }

        private void UpdateCounts()
        {
            labelList.Text = $"Items in List: {SomeObjects.Count}";
            labelListBox.Text = $"Items in ListBox: {listBoxToBindTo.Items.Count}";
        }

        private void AddDataToBindingList()
        {
            SomeObjects.Add ( new SomeObject { Integer = 0, String = "Zero"} );
            SomeObjects.Add ( new SomeObject { Integer = 1, String = "One" } );
            SomeObjects.Add ( new SomeObject { Integer = 2, String = "Two" } );
        }

        private void buttonBind_Click(object sender, EventArgs e)
        {
            listBoxToBindTo.DataSource = SomeObjects;
            UpdateCounts();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                SomeObject someObject = new SomeObject { Integer = Convert.ToInt32(textBoxInt.Text), String = textBoxString.Text };
                SomeObjects.Add(someObject);
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }

            // ResetBindings call only appears to be needed when changing
            //  the value of items, not when adding or removing items.
            //SomeObjects.ResetBindings();

            UpdateCounts();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int IndexToRemove = listBoxToBindTo.SelectedIndex;
            SomeObjects.RemoveAt ( IndexToRemove );
            UpdateCounts();
        }

        public void Error(string message, [System.Runtime.CompilerServices.CallerMemberName] string caller = "")
        {
            MessageBox.Show(message, caller);
        }
    }

    [Serializable]
    public class SomeObject
    {
        public int Integer { get; set; }

        public string String { get; set; } = "Default";

        public override string ToString()
        {
            return String;
        }

    }
}
