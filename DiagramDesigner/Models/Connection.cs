using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace DiagramDesigner.Models
{
    class Connection: Item
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public Item StartItem { get; set; }

        public Item EndItem { get; set; }

        public double Angle { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
