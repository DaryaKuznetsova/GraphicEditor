﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDesigner.ViewModels
{
    class DiagramViewModel : INPCBase, IDiagramViewModel
    {
        private ObservableCollection<SelectedItemViewModel> items = new ObservableCollection<SelectedItemViewModel>();

        public DiagramViewModel()
        {
            AddItemCommand = new SimpleCommand(ExecuteAddItemCommand);
            RemoveItemCommand = new SimpleCommand(ExecuteRemoveItemCommand);
            CreateNewDiagramCommand = new SimpleCommand(ExecuteCreateNewDiagramCommand);
            SaveDiagramCommand = new SimpleCommand(ExecuteSaveDiagramCommand);
        }


        public SimpleCommand AddItemCommand { get; private set; }
        public SimpleCommand RemoveItemCommand { get; private set; }
        public SimpleCommand CreateNewDiagramCommand { get; private set; }
        public SimpleCommand SaveDiagramCommand { get; private set; }

        public ObservableCollection<SelectedItemViewModel> Items
        {
            get { return items; }
        }

        public List<SelectedItemViewModel> SelectedItems
        {
            get { return Items.Where(x => x.IsSelected).ToList(); }
        }

        public int Width
        {
            get => default;
            set
            {
            }
        }

        public int Height
        {
            get => default;
            set
            {
            }
        }

        public int BackgroundColor
        {
            get => default;
            set
            {
            }
        }

        public int OpenExistingDiagramCommand
        {
            get => default;
            set
            {
            }
        }

        public int ChangeHeightCommand
        {
            get => default;
            set
            {
            }
        }

        public int ChangeWidthCommand
        {
            get => default;
            set
            {
            }
        }

        public int ChangeBackgroundColor
        {
            get => default;
            set
            {
            }
        }

        public int ChangeItemCommand
        {
            get => default;
            set
            {
            }
        }

        private void ExecuteAddItemCommand(object parameter)
        {
            if (parameter is SelectedItemViewModel)
            {
                SelectedItemViewModel item = (SelectedItemViewModel)parameter;
                item.Parent = this;
                items.Add(item);
            }
        }

        private void ExecuteRemoveItemCommand(object parameter)
        {
            if (parameter is SelectedItemViewModel)
            {
                SelectedItemViewModel item = (SelectedItemViewModel)parameter;
                items.Remove(item);
            }
        }


        private void ExecuteCreateNewDiagramCommand(object parameter)
        {
            Items.Clear();
        }

        private void ExecuteSaveDiagramCommand(object parameter)
        {
            Items.Clear();
        }

        public void ExecuteChangeBackgroundColorCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeHeightCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeWidthCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteChangeItemCommand()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteOpenExistingDiagramCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}
