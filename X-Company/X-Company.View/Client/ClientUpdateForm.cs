
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ClientUpdateForm : Form
    {
        private readonly BaseRepository<Client> mainRepository;
        private readonly Client entityToEdit;
        public ClientUpdateForm(BaseRepository<Client> mainRepository, Client entity)
        {
            InitializeComponent();
            entityToEdit = entity;
            this.mainRepository = mainRepository;
            LoadFieldsFromEntity(entity);
        }

        private void LoadFieldsFromEntity(Client entity)
        {
            titleLabel.Text += entity.Name;
            nameTextBox.Text = entity.Name;
            addressTextBox.Text = entity.Address;
            phoneTextBox.Text = entity.Phone;
            emailTextBox.Text = entity.Email;
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
                if (mainRepository.Update(entityToEdit.Id, entity))
                {
                    MessageBox.Show("Entity updated sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Unknown error when updating entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }

            }
            else
            {
                MessageBox.Show($"Validation error when updating entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)  //allows only numbers on Textobx
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
