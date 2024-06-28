using Microsoft.Reporting.WinForms;
using X_Company.Domain.Features;

namespace X_Company.Reports
{
    public partial class ProductReportForm : Form
    {
        private readonly List<Product> entityDataSource;
        private readonly ReportViewer reportViewer;

        public ProductReportForm(List<Product> entityDataSource)
        {
            InitializeComponent();
            this.entityDataSource = entityDataSource;
            reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };
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
            var parameters = new[] { new ReportParameter("Title", "Product Report") };
            using var fs = new FileStream("..\\..\\..\\..\\X-Company.Reports\\ProductReport.rdlc", FileMode.Open);       //might not work folders are different than solution
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("ProductDataSet", entityDataSource));
            report.SetParameters(parameters);
        }

    }
}
