using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace DiagramDesigner.Models
{
    class Item
    {
        public int Id { get; set; }

        public int Wigth { get; set; }

        public int Height { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Color FontColor { get; set; }

        public Color BackroundColor { get; set; }

        public int LineHeight { get; set; }

        public Group Group { get; set; }

        public string Text { get; set; }

        public List<Connection> ConnectionList;

        public int Level;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
