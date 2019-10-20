using System;
using System.Collections.Generic;

namespace ExportHistoryReport.BusinessLayer
{
    public interface IExportRepository
    {
        /// <summary>
        /// Gets the locations.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetLocations();

        /// <summary>
        /// Loads all items.
        /// </summary>
        /// <param name="locationName">Name of the location.</param>
        /// <param name="dateSince">The date since.</param>
        /// <param name="dateTill">The date till.</param>
        /// <returns></returns>
        IEnumerable<ExportData> LoadItems(string locationName = null, DateTime? dateSince = null, DateTime? dateTill = null);
    }
}
