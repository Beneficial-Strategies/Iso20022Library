// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GYK4MZfJEeuqNYk2TG3bTg")]
[Description(@"Type of customer device.")]
[DerivedFrom(typeof(CustomerDeviceTypeCode))]
public enum CustomerDeviceType2Code
{
    /// <summary>
    /// Mobile phone
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_GeUjgZfJEeuqNYk2TG3bTg")]
    [Description(@"Mobile phone")]
    Mobile = CustomerDeviceTypeCode.Mobile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other device defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_GeUjg5fJEeuqNYk2TG3bTg")]
    [Description(@"Other device defined at national level")]
    OtherNational = CustomerDeviceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other device defined in a private way.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_GeUjhZfJEeuqNYk2TG3bTg")]
    [Description(@"Other device defined in a private way.")]
    OtherPrivate = CustomerDeviceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal computer
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_GeUjh5fJEeuqNYk2TG3bTg")]
    [Description(@"Personal computer")]
    PersonalComputer = CustomerDeviceTypeCode.PersonalComputer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tablet
    /// Encoded/decoded by serializers as &quot;TBLT&quot;.
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_GeUjiZfJEeuqNYk2TG3bTg")]
    [Description(@"Tablet")]
    Tablet = CustomerDeviceTypeCode.Tablet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-secure card reader attached to the customer device.
    /// Encoded/decoded by serializers as &quot;NSCR&quot;.
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_GeUji5fJEeuqNYk2TG3bTg")]
    [Description(@"Non-secure card reader attached to the customer device.")]
    NonSecureCardReader = CustomerDeviceTypeCode.NonSecureCardReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure card reader attached to the customer device
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_GeUjjZfJEeuqNYk2TG3bTg")]
    [Description(@"Secure card reader attached to the customer device")]
    SecureCardReader = CustomerDeviceTypeCode.SecureCardReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Embedded in a device.
    /// Encoded/decoded by serializers as &quot;EMBD&quot;.
    /// </summary>
    [EnumMember(Value = "EMBD")]
    [IsoId("_jCjZAZfJEeuqNYk2TG3bTg")]
    [Description(@"Embedded in a device.")]
    Embedded = CustomerDeviceTypeCode.Embedded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vehicle.
    /// Encoded/decoded by serializers as &quot;VHCL&quot;.
    /// </summary>
    [EnumMember(Value = "VHCL")]
    [IsoId("_jkdMMZfJEeuqNYk2TG3bTg")]
    [Description(@"Vehicle.")]
    Vehicle = CustomerDeviceTypeCode.Vehicle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wearable device.
    /// Encoded/decoded by serializers as &quot;WRBL&quot;.
    /// </summary>
    [EnumMember(Value = "WRBL")]
    [IsoId("_j6peoZfJEeuqNYk2TG3bTg")]
    [Description(@"Wearable device.")]
    Wearable = CustomerDeviceTypeCode.Wearable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Watch
    /// Encoded/decoded by serializers as &quot;WATC&quot;.
    /// </summary>
    [EnumMember(Value = "WATC")]
    [IsoId("_V800YSbNEeyhZIgCcGlTyA")]
    [Description(@"Watch")]
    Watch = CustomerDeviceTypeCode.Watch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gaming Device
    /// Encoded/decoded by serializers as &quot;GAMB&quot;.
    /// </summary>
    [EnumMember(Value = "GAMB")]
    [IsoId("_WCc7QSbNEeyhZIgCcGlTyA")]
    [Description(@"Gaming Device")]
    GamingDevice = CustomerDeviceTypeCode.GamingDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Jewellery
    /// Encoded/decoded by serializers as &quot;JEWL&quot;.
    /// </summary>
    [EnumMember(Value = "JEWL")]
    [IsoId("_WHQiwSbNEeyhZIgCcGlTyA")]
    [Description(@"Jewellery")]
    Jewellery = CustomerDeviceTypeCode.Jewellery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key Fob
    /// Encoded/decoded by serializers as &quot;KFOB&quot;.
    /// </summary>
    [EnumMember(Value = "KFOB")]
    [IsoId("_WPLvsSbNEeyhZIgCcGlTyA")]
    [Description(@"Key Fob")]
    KeyFob = CustomerDeviceTypeCode.KeyFob, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sticker
    /// Encoded/decoded by serializers as &quot;STIC&quot;.
    /// </summary>
    [EnumMember(Value = "STIC")]
    [IsoId("_WjVawSbNEeyhZIgCcGlTyA")]
    [Description(@"Sticker")]
    Sticker = CustomerDeviceTypeCode.Sticker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device type unknown
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_dOHV4UQHEeyANrrBvBlqVg")]
    [Description(@"Device type unknown")]
    Unknown = CustomerDeviceTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
