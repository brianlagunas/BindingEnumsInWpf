using BindingEnums.Resources;
using System.ComponentModel;

namespace BindingEnums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        [Description("This is horrible")]
        Horrible,
        [Description("This is bad")]
        Bad,
        [Description("This is so so")]
        SoSo,
        [LocalizedDescription("Good", typeof(EnumResources))]
        Good,
        [LocalizedDescription("Better", typeof(EnumResources))]
        Better,
        [LocalizedDescription("Best", typeof(EnumResources))]
        Best
    }
}
