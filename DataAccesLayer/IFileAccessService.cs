using DiagramDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccesLayer
{
    interface IFileAccessService
    {

        //Diagram Methods
        int SaveDiagram(Diagram diagram);
        //PersistDesignerItem is pecific to the DemoApp example
        int SaveReserveDiagram(Diagram diagram);
        //PersistDesignerItem is pecific to the DemoApp example
        Diagram FindDiagram(string path);


        //ItemMethods
        List<Item> ParseItemsFromXML(string path);
        Item ParseItemFromXML();
        void SavePngDiagram();
    }
}
