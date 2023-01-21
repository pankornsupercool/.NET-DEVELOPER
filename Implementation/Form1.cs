using System.Diagnostics;
using System.Linq;
namespace Implementation
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        DataAccess db = new DataAccess();

        public static string selectedTable;
        public Form1()
        {
            var tables = new List<Table>();
            tables.Add(new Table() { TableName = "Person" });
            tables.Add(new Table() { TableName = "LolUniverse" });

            InitializeComponent();
            ListBox.DataSource = people;
            ListBox.DisplayMember = "FullInfo";

            
            SelectCombobox.DisplayMember = "TableInfo";
            SelectCombobox.DataSource = tables;
            //SelectCombobox.ValueMember = "TableName";

            PLinq();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            selectedTable = SelectCombobox.Text;
            if (RadioId.Checked)
            {
                people = db.GetPeopleById(TextBox.Text, selectedTable);
            }
            else if (RadioLastname.Checked)
            {
                people = db.GetPeopleByLastname(TextBox.Text, selectedTable);
            }
            else if (RadioCity.Checked)
            {
                people = db.GetPeopleByCity(TextBox.Text, selectedTable);
            }


            //Update Listbox
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            ListBox.Refresh();
            ListBox.DataSource = people;
            ListBox.DisplayMember = "Name";
        }

        private void SelectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = SelectCombobox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedTable = SelectCombobox.Text;
            DataAccess db = new DataAccess();

            people = db.GetAllPeople(selectedTable);

            RefreshListBox();
        }

        private void PLinq()
        {
            var numbers = new int[] { 99, 2, 74, 42, 11, 45, 62, 70, 94, 202, 324 };
            var numberCollection = new List<int>();

            //Linq expression
            numberCollection = numbers.Where(it => it % 2 == 0).OrderByDescending(it => it).ToList();
            foreach (var number in numberCollection)
            {
                Debug.WriteLine($"{number}");
            }
        }


        private void _insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.InsertPeople(_insertIdTextbox.Text, _insertFirstnameTextbox.Text, _insertLastnameTextbox.Text, _insertCityTextbox.Text, selectedTable);
                _executionStatusLabel.Text = "Success";
            }
            catch(Exception)
            {
                _executionStatusLabel.Text = "Failed";
            }
            
            _insertIdTextbox.Clear();
            _insertFirstnameTextbox.Clear();
            _insertLastnameTextbox.Clear();
            _insertCityTextbox.Clear();
        }

        private void modifyPage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _executionStatusLabel.Text = ListBox.GetItemText(ListBox.SelectedItem);

            Debug.WriteLine(_executionStatusLabel.Text);

            string s = _executionStatusLabel.Text;
            string[] subs = s.Split(',',' ');

            foreach (var items in subs)
            {
                Debug.WriteLine(items);
            }

            //Debug.WriteLine(subs[0]);

            _updateIdTextbox.Text = subs[0];
            _updateFirstnameTextbox.Text= subs[1];
            _updateLastnameTextbox.Text = subs[2];
            _updateCityTextbox.Text = subs[3];

        }

        private void _updateButton_Click(object sender, EventArgs e)
        {
            //db.UpdatePeople(_updateIdTextbox.Text, _updateFirstnameTextbox.Text, _updateLastnameTextbox.Text, _updateCityTextbox.Text);
            //_updateExecutionStatusLabel.Text = "Success";
            try
            {
                db.UpdatePeople(_updateIdTextbox.Text, _updateFirstnameTextbox.Text, _updateLastnameTextbox.Text, _updateCityTextbox.Text, selectedTable);
                _updateExecutionStatusLabel.Text = "Success";
            }
            catch (Exception)
            {
                _updateExecutionStatusLabel.Text = "Failed";
            }
            finally
            {
                RefreshListBox();
            }
        }
    }
}