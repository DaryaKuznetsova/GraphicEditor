using DiagramDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.ViewModels
{
    class PersistDesignerItemData: INPCBase
    {
        private string hostUrl = "";

        public PersistDesignerItemData(string currentHostUrl)
        {
            hostUrl = currentHostUrl;
        }

        public string HostUrl
        {
            get
            {
                return hostUrl;
            }
            set
            {
                if (hostUrl != value)
                {
                    hostUrl = value;
                    NotifyChanged("HostUrl");
                }
            }
        }
    }
}
