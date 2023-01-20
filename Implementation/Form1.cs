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

            SelectCombobox.DataSource = tables;
            SelectCombobox.DisplayMember = "FullInfo";
            SelectCombobox.ValueMember = "TableName";

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
            Debug.WriteLine(SelectCombobox.Text);
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
    }
}