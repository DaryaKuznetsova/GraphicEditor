using Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{

    /// <summary>
    /// I decided to use RavenDB instead of SQL, to save people having to have SQL Server, and also
    /// it just takes less time to do with Raven. This is ALL the CRUD code. Simple no?
    /// 
    /// Thing is the IDatabaseAccessService and the items it persists could easily be applied to helper methods that
    /// use StoredProcedures or ADO code, the data being stored would be exactly the same. You would just need to store
    /// the individual property values in tables rather than store objects.
    /// </summary>
    public class FileAccessService : IFileAccessService
    {



        public FileAccessService()
        {

        }

        public void DeleteConnection(int connectionId)
        {

        }

        public void DeletePersistDesignerItem(int persistDesignerId)
        {

        }

        public void DeleteSettingDesignerItem(int settingsDesignerItemId)
        {

        }

        public int SaveDiagram(DiagramItem diagram)
        {
            return SaveItem(diagram);
        }

        public int SavePersistDesignerItem(PersistDesignerItem persistDesignerItemToSave)
        {
            return SaveItem(persistDesignerItemToSave);
        }

        public int SaveSettingDesignerItem(SettingsDesignerItem settingsDesignerItemToSave)
        {
            return SaveItem(settingsDesignerItemToSave);
        }

        public int SaveGroupingDesignerItem(GroupDesignerItem groupDesignerItemToSave)
        {
            return SaveItem(groupDesignerItemToSave);
        }

        public int SaveConnection(Connection connectionToSave)
        {
            return SaveItem(connectionToSave);
        }

        public IEnumerable<DiagramItem> FetchAllDiagram()
        {
            return null;
        }

        public DiagramItem FetchDiagram(int diagramId)
        {
            return null;
        }

        public PersistDesignerItem FetchPersistDesignerItem(int settingsDesignerItemId)
        {
            return null;
        }

        public SettingsDesignerItem FetchSettingsDesignerItem(int settingsDesignerItemId)
        {
            return null;
        }

        public GroupDesignerItem FetchGroupingDesignerItem(int groupDesignerItemId)
        {
            return null;
        }
        public Connection FetchConnection(int connectionId)
        {
            return null;
        }

        private int SaveItem(PersistableItemBase item)
        {
            return 0;
        }
    }
}
