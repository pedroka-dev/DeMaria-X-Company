﻿using X_Company.Domain.Features;
using X_Company.ORM;
using X_Company.Reports;

namespace X_Company.View
{
    public partial class ClientViewForm : Form
    {
        private readonly BindingSource bindingSource;
        private readonly BaseRepository<Client> mainRepository;

        public ClientViewForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            bindingSource = [];
            mainRepository = new BaseRepository<Client>(new XCompanyDBContext());
        }

        protected override void OnLoad(EventArgs e)
        {
            ReloadDataGridAsync(true);
            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            mainRepository.DisposeDb();
            base.OnFormClosed(e);
        }

        public async void ReloadDataGridAsync(bool configureGrid = false)
        {
            bindingSource.DataSource = await Task.Run(mainRepository.SelectAll);
            dataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            if (dataGridView.RowCount > 0)
            {
                dataGridView.Columns["Id"].DisplayIndex = 0;
                dataGridView.Columns["Name"].DisplayIndex = 1;
                dataGridView.Columns["Address"].DisplayIndex = 2;
                dataGridView.Columns["Phone"].DisplayIndex = 3;
                dataGridView.Columns["Email"].DisplayIndex = 4;
            }
        }

        private int GetSelectedEntityId()
        {
            int selectedRowIndex = dataGridView.SelectedRows[0].Index;
            int entityId = (int)dataGridView.Rows[selectedRowIndex].Cells["Id"].Value;
            return entityId;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var form = new ClientInsertForm(mainRepository);
            form.ShowDialog();
            ReloadDataGridAsync();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var entity = mainRepository.SelectById(GetSelectedEntityId());
            var form = new ClientUpdateForm(mainRepository, entity);
            form.ShowDialog();
            ReloadDataGridAsync();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Select at least one entity before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected entity? Depedent entities might get deleted too.", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (mainRepository.Delete(GetSelectedEntityId()))
                    {
                        MessageBox.Show("Entity deleted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unknown error when deleting Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       ////TOOD: Catch exception instead
                    }
                }
            }
            ReloadDataGridAsync();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            var form = new ClientReportForm(mainRepository.SelectAll());
            form.ShowDialog();
            ReloadDataGridAsync();
        }

    }
}
