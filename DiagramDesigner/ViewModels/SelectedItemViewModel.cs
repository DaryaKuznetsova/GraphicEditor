using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDesigner.ViewModels
{
    public interface ISelectItems
    {
        SimpleCommand SelectItemCommand { get; }
    }


    public abstract class SelectedItemViewModel : INPCBase, ISelectItems
    {
        private bool isSelected;

        public SelectedItemViewModel(int id, IDiagramViewModel parent)
        {
            this.Id = id;
            this.Parent = parent;
            Init();
        }

        public SelectedItemViewModel()
        {
            Init();
        }

        public List<SelectedItemViewModel> SelectedItems
        {
            get { return Parent.SelectedItems; }
        }

        public IDiagramViewModel Parent { get; set; }
        public SimpleCommand SelectItemCommand { get; private set; }
        public int Id { get; set; }

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                if (isSelected != value)
                {

                    isSelected = value;
                    NotifyChanged("IsSelected");
                }
            }
        }

        private void ExecuteSelectItemCommand(object param)
        {
            SelectItem((bool)param, !IsSelected);
        }

        private void SelectItem(bool newselect, bool select)
        {
            if (newselect)
            {
                foreach (var designerItemViewModelBase in Parent.SelectedItems.ToList())
                {
                    designerItemViewModelBase.isSelected = false;
                }
            }

            IsSelected = select;
        }

        private void Init()
        {
            SelectItemCommand = new SimpleCommand(ExecuteSelectItemCommand);
        }

        public void ExecuteChangeWidthCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeHeightCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeLeftCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeTopCommang()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeFontColorCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeBackgroundColorCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeLineHeightCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeTextCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeLevelCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeAngleCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}
