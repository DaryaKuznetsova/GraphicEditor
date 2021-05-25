using DiagramDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.ViewModels
{
    class SettingsDesignerItemData: INPCBase
    {
        private string setting1 = "";

        public SettingsDesignerItemData(string currentSetting1)
        {
            setting1 = currentSetting1;
        }


        public string Setting1
        {
            get
            {
                return setting1;
            }
            set
            {
                if (setting1 != value)
                {
                    setting1 = value;
                    NotifyChanged("Setting1");
                }
            }
        }
    }
}
