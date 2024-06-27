
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ClientInsertForm : Form
    {
        private readonly BaseRepository<Client> repository;

        public ClientInsertForm(BaseRepository<Client> repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var address = addressTextBox.Text;
            var phone = phoneTextBox.Text;
            var email = emailTextBox.Text;

            var entity = new Client(name, address, phone, email);

            var validationMessage = entity.Validate();
            if (validationMessage.Equals("VALID"))
            {
                if (repository.Insert(entity))
                {
                    MessageBox.Show("Entity inserted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown error when inserting Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }


                this.Dispose();
            }
            else
            {
                MessageBox.Show($"Validation error when inserting entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
