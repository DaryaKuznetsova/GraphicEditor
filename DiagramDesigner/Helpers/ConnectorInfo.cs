﻿using DiagramDesigner.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DiagramDesigner.Helpers
{
    public struct ConnectorInfo
    {
    public double DesignerItemLeft { get; set; }
    public double DesignerItemTop { get; set; }
    public Size DesignerItemSize { get; set; }
    public Point Position { get; set; }
    public ConnectorOrientation Orientation { get; set; }
    }
}
