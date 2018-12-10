using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BindingEnums
{
    class InputParameterTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Checkbox { get; set; }
        public DataTemplate ComboBox { get; set; }
        public DataTemplate DatePicker { get; set; }
        public DataTemplate TextBox { get; set; }

        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
            {
                if (item != null && item is InputParameter)
                {
                    var taskitem = (InputParameter)item;

                    if (taskitem.Type == typeof(Boolean))
                        return Checkbox;
                    if (taskitem.Type == typeof(DateTime))
                        return DatePicker;
                    if (taskitem.Type.IsEnum)
                        return ComboBox;
                    return TextBox;
                }

                return null;
            }
    }
}
