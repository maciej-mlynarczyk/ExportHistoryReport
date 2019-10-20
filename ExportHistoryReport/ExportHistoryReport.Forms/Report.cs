using ExportHistoryReport.BusinessLayer;
using System;
using System.Windows.Forms;
using System.Linq;

namespace ExportHistoryReport.Forms
{
    public partial class Report : Form
    {
        private IExportRepository _ExportRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        public Report()
        {
            _ExportRepository = UnityHelper.Resolve<IExportRepository>();
            InitializeComponent();
            LocationFilterEdit.Properties.Items.AddRange(_ExportRepository.GetLocations().ToList());
        }

        /// <summary>
        /// Handles the Click event of the FilterAcceptButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FilterAcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                var locationName = LocationFilterEdit.SelectedItem.ToString();
                ExportHistoryGrid.DataSource = _ExportRepository.LoadItems(locationName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(FilterAcceptButton, ex.Message, "Błąd podczas pobierania danych");
            }
        }
    }
}
