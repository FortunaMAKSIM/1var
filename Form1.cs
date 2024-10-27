

using _1var.Data;

namespace _1var
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _dbContext;
        public Form1(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogBt_Click(object sender, EventArgs e)
        {
            string username = LoginTb.Text;
            string password = PasswordTb.Text;

            var user = _dbContext.Staffs.FirstOrDefault(s => s.Login == username && s.Password == password);

            if (user != null) 
            {
                Form2 form2 = new Form2(_dbContext);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
