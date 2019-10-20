using ExportHistoryReport.BusinessLayer;
using ExportHistoryReport.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExportHistoryReport.DataLayer
{
    public class ExportRepository : IExportRepository
    {
        /// <summary>
        /// Gets the locations.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetLocations()
        {
            using (ExportHistoryReportEntities context = new ExportHistoryReportEntities())
            {
                return context.Exports.Select(t => t.LocationName).Distinct().ToList();
            }
        }

        /// <summary>
        /// Loads the items.
        /// </summary>
        /// <param name="locationName">Name of the location.</param>
        /// <param name="dateSince">The date since.</param>
        /// <param name="dateTill">The date till.</param>
        /// <returns></returns>
        public IEnumerable<ExportData> LoadItems(string locationName = null, DateTime? dateSince = null, DateTime? dateTill = null)
        {
            using (ExportHistoryReportEntities context = new ExportHistoryReportEntities())
            {
                var query = from e in context.Exports
                            orderby e.ExecutionDateTime
                            select new ExportData
                            {
                                ID = e.ID,
                                Name = e.Name,
                                ExecutionDateTime = e.ExecutionDateTime,
                                UserName = e.UserName,
                                LocationName = e.LocationName
                            };
                if (!string.IsNullOrEmpty(locationName))
                {
                    query = query.Where(t => t.LocationName == locationName);
                }
                if (dateSince != null)
                {
                    query = query.Where(t => t.ExecutionDateTime >= dateSince);
                }
                if (dateTill != null)
                {
                    query = query.Where(t => t.ExecutionDateTime <= dateTill);
                }
                return query.ToList();
            }
        }
    }
}
