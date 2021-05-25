using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DiagramDesigner.Models
{
    class Diagram
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Color BackgroundColor { get; set; }

        public Dictionary<int, Item> ItemDictionary { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
