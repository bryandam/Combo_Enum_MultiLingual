using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace BindingEnums
{
    public class EnumDescriptionTypeConverter : EnumConverter
    {
        public EnumDescriptionTypeConverter(Type type)
            : base(type)
        {}

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value != null)
                {
                    FieldInfo fi = value.GetType().GetField(value.ToString());
                    if (fi != null)
                    {
                        //Reflect into the value's type to get the display attributes.
                        FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
                        DisplayAttribute displayAttribute = fieldInfo?
                                                        .GetCustomAttributes(false)
                                                        .OfType<DisplayAttribute>()
                                                        .SingleOrDefault();
                        if (displayAttribute == null)
                        {
                            return value.ToString();
                        }
                        else
                        {
                            //Look up the localized string.
                            ResourceManager resourceManager = new ResourceManager(displayAttribute.ResourceType);                            
                            string name = resourceManager.GetString(displayAttribute.Name);
                            return string.IsNullOrWhiteSpace(name) ? displayAttribute.Name : name;
                        }
                    }
                }

                return string.Empty;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
