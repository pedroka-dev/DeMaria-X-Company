using Microsoft.Reporting.WinForms;
using X_Company.Domain.Features;

namespace X_Company.Reports
{
    public partial class ClientReportForm : Form
    {
        private readonly List<Client> entityDataSource;
        private readonly ReportViewer reportViewer;

        public ClientReportForm(List<Client> entityDataSource)
        {
            InitializeComponent();
            this.entityDataSource = entityDataSource;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadReport(reportViewer.LocalReport);
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }


        protected void LoadReport(LocalReport report)
        {
            var parameters = new[] { new ReportParameter("Title", "Client Report") };
            using var fs = new FileStream("..\\..\\..\\..\\X-Company.Reports\\ClientReport.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("ClientDataSet", entityDataSource));
            report.SetParameters(parameters);
        }

    }
}
