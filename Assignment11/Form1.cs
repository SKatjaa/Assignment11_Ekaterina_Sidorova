namespace Assignment11
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*string userPetType;
            userPetType = textBox2.Text;
            string[] Types = new string[] { "cat", "dog", "fish", "bird", "turtle", "rabbit", "hamster", "rat", "mouse", "snake" };

            for (int i = 0; i < Types.Length; i++)
            {
                if (Types[i] != userPetType.ToLower())
                {
                    label6.Text = "Enter valid pet type";
                    label6.Visible = true;
                }
                else
                {
                    break;
                }
            }*/

            Pet userPet = new Pet();
            userPet.Name = textBox1.Text;
            userPet.Type = textBox2.Text;
            userPet.Age = textBox3.Text;

            label5.Text = "Your pet is " + userPet.Type + ". Its name is " + userPet.Name + ". It is " + userPet.Age + " years old.";
            label5.Visible = true;
        }
    }
        
    class Pet
    {
        private string _name = "Kitty";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _type = "Cat";
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _age = "7";
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
    } 
}

