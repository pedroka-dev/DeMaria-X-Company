using Microsoft.EntityFrameworkCore;
using X_Company.ORM;

namespace X_Company
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XCompanyDBContext db = new();
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();

            Application.Run(new MainMenuForm());
        }
    }
}
