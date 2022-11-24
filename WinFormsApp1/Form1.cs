namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        Class1 pet;
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string type = typeTxt.Text;
            decimal Age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(ageTxt.Text, out Age))
            {
                pet = new Class1(name, type, Age);
            }
            else
                MessageBox.Show("Invalid input");
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Pet's Name: " + pet.Name);
                listBox1.Items.Add("Pet's Type: " + pet.Type);
                listBox1.Items.Add("Pet's Age: " + pet.Age);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to enter information first!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ageTxt.Text = "";
            nameTxt.Text = "";
            typeTxt.Text = "";
            listBox1.Items.Clear();
        }
    }

}