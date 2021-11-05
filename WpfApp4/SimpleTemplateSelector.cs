using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
    public class SimpleTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            try
            {
                return (DataTemplate)((FrameworkElement)container).FindResource(item);
            }
            catch
            {
                return null;
            }
        }
    }
}