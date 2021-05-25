using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDesigner.ViewModels
{
    public interface IDiagramViewModel
    {
        SimpleCommand AddItemCommand { get; }
        SimpleCommand RemoveItemCommand { get; }
        List<SelectedItemViewModel> SelectedItems { get; }
        ObservableCollection<SelectedItemViewModel> Items { get; }
    }
}
