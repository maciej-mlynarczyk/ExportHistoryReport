using Unity;

namespace ExportHistoryReport.DataLayer
{
    public class RepositoryHelper
    {
        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        internal static UnityContainer Container { get; } = ConfigureUnity();

        /// <summary>
        /// Configures the unity.
        /// </summary>
        internal static UnityContainer ConfigureUnity()
        {
            var container = new UnityContainer();
            container.RegisterSingleton<IExportRepository, Entities.ExportRepository>();
            return container;
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
