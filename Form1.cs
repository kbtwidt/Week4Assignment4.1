namespace Week4Assignment4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PhoneBookGrid.DataSource = Data.PhoneBook.Values.ToList();
            lblFName.Hide();
            lblLName.Hide();
            lblMobile.Hide();
            lblAddress.Hide();
            lblOffice.Hide();
            txtFName.Hide();
            txtLName.Hide();
            txtMobile.Hide();
            txtOffice.Hide();
            txtAddress.Hide();
            btnAdd2.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblFName.Show();
            lblLName.Show();
            lblMobile.Show();
            lblAddress.Show();
            lblOffice.Show();
            txtFName.Show();
            txtLName.Show();
            txtMobile.Show();
            txtOffice.Show();
            txtAddress.Show();
            btnAdd2.Show();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != string.Empty && txtLName.Text != string.Empty)
            {
                var newEntry = new Person();
                newEntry.FirstName = txtFName.Text;
                newEntry.LastName = txtLName.Text;
                if (long.TryParse(txtMobile.Text, out long mobile))
                    newEntry.MobilePhone = mobile;
                else
                    newEntry.MobilePhone = 0;
                if (long.TryParse(txtOffice.Text, out long office))
                    newEntry.WorkPhone = office;
                else
                    newEntry.WorkPhone = 0;
                newEntry.Address = txtAddress.Text;

                if (Data.PhoneBook.ContainsKey(txtLName.Text + txtFName.Text))
                {
                    MessageBox.Show("A person with this name already exists.");
                    txtFName.Clear();
                    txtLName.Clear();
                    txtMobile.Clear();
                    txtOffice.Clear();
                    txtAddress.Clear();
                    return;
                }
                else
                {
                    Data.PhoneBook.Add(newEntry.LastName + newEntry.FirstName, newEntry);
                    PhoneBookGrid.DataSource = Data.PhoneBook.Values.ToList();
                }

                var result = MessageBox.Show("New Phone Book entry added. Would you like to add another?", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtFName.Clear();
                    txtLName.Clear();
                    txtMobile.Clear();
                    txtOffice.Clear();
                    txtAddress.Clear();
                }
                else
                {
                    lblFName.Hide();
                    lblLName.Hide();
                    lblMobile.Hide();
                    lblAddress.Hide();
                    lblOffice.Hide();
                    txtFName.Hide();
                    txtLName.Hide();
                    txtMobile.Hide();
                    txtOffice.Hide();
                    txtAddress.Hide();
                    btnAdd2.Hide();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this Phone Book Entry?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string key = PhoneBookGrid.CurrentRow.Cells[1].Value.ToString() + PhoneBookGrid.CurrentRow.Cells[0].Value.ToString();
                Data.PhoneBook.Remove(key);
                PhoneBookGrid.DataSource = Data.PhoneBook.Values.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                string search = txtSearch.Text.Trim();
                List<Person> results = new List<Person>();

                foreach(Person person in Data.PhoneBook.Values)
                {
                    if(person.FirstName == search || person.LastName == search || person.FirstName + " " + person.LastName == search)
                    {
                        results.Add(person);
                    }
                }
                PhoneBookGrid.DataSource = results;
            }

            else
            {
                PhoneBookGrid.DataSource = Data.PhoneBook.Values.ToList();
            }

        }
    }
}
