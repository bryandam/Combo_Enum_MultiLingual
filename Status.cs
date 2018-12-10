using BindingEnums.Resources;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BindingEnums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {        
        [Display(Name = nameof(Resources.EnumResources.Good), ResourceType = typeof(Resources.EnumResources))]
        Good,
        [Display(Name = nameof(Resources.EnumResources.Better), ResourceType = typeof(Resources.EnumResources))]
        Better,
        Best
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Foo
    {
        [Display(Name = nameof(Resources.EnumResources.Good), ResourceType = typeof(Resources.EnumResources))]
        Foo,
        [Display(Name = nameof(Resources.EnumResources.Better), ResourceType = typeof(Resources.EnumResources))]
        Bar
    }
}
