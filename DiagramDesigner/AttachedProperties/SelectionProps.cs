using DiagramDesigner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DiagramDesigner.AttachedProperties
{
    public static class SelectionProps
    {
        #region EnabledForSelection

        public static readonly DependencyProperty EnabledForSelectionProperty =
            DependencyProperty.RegisterAttached("EnabledForSelection", typeof(bool), typeof(SelectionProps),
                new FrameworkPropertyMetadata((bool)false,
                    new PropertyChangedCallback(OnEnabledForSelectionChanged)));

        public static bool GetEnabledForSelection(DependencyObject d)
        {
            return (bool)d.GetValue(EnabledForSelectionProperty);
        }

        public static void SetEnabledForSelection(DependencyObject d, bool value)
        {
            d.SetValue(EnabledForSelectionProperty, value);
        }

        private static void OnEnabledForSelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FrameworkElement fe = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                fe.PreviewMouseDown += Fe_PreviewMouseDown;
            }
            else
            {
                fe.PreviewMouseDown -= Fe_PreviewMouseDown;
            }
        }

        #endregion

        static void Fe_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SelectedItemViewModelBase selectableDesignerItemViewModelBase =
                (SelectedItemViewModelBase)((FrameworkElement)sender).DataContext;

            if (selectableDesignerItemViewModelBase != null)
            {
                if ((Keyboard.Modifiers & (ModifierKeys.Shift | ModifierKeys.Control)) != ModifierKeys.None)
                {
                    if ((Keyboard.Modifiers & (ModifierKeys.Shift)) != ModifierKeys.None)
                    {
                        selectableDesignerItemViewModelBase.IsSelected = !selectableDesignerItemViewModelBase.IsSelected;
                    }

                    if ((Keyboard.Modifiers & (ModifierKeys.Control)) != ModifierKeys.None)
                    {
                        selectableDesignerItemViewModelBase.IsSelected = !selectableDesignerItemViewModelBase.IsSelected;
                    }
                }
                else if (!selectableDesignerItemViewModelBase.IsSelected)
                {
                    foreach (SelectedItemViewModelBase item in selectableDesignerItemViewModelBase.Parent.SelectedItems)
                    {

                        if (item is IDiagramViewModel)
                        {
                            IDiagramViewModel tmp = (IDiagramViewModel)item;
                            foreach (SelectedItemViewModelBase gItem in tmp.Items)
                            {
                                gItem.IsSelected = false;
                            }

                        }
                        if (selectableDesignerItemViewModelBase.Parent is SelectedItemViewModelBase)
                        {
                            SelectedItemViewModelBase tmp = (SelectedItemViewModelBase)selectableDesignerItemViewModelBase.Parent;
                            tmp.IsSelected = false;
                        }
                        item.IsSelected = false;
                    }
                    if (selectableDesignerItemViewModelBase is IDiagramViewModel)
                    {
                        IDiagramViewModel tmp = (IDiagramViewModel)selectableDesignerItemViewModelBase;
                        foreach (SelectedItemViewModelBase gItem in tmp.Items)
                        {
                            gItem.IsSelected = false;
                        }

                    }
                    selectableDesignerItemViewModelBase.Parent.SelectedItems.Clear();
                    selectableDesignerItemViewModelBase.IsSelected = true;
                }
            }
        }
    }
}
