using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace dts_template_resource.Converters
{
    public class HalfConverter : MarkupExtension, IValueConverter
    {
        private static HalfConverter _instance;

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = ((Double)value) / 2;
            return val;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion IValueConverter Members

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new HalfConverter());
        }
    }
}