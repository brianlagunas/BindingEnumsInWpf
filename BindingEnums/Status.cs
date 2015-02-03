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
        [Description("This is good")]
        Good,
        [Description("This is better")]
        Better,
        [Description("This is best")]
        Best
    }
}
