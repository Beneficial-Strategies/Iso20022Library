// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IQUBoEetEee9r7QjOdsbFw")]
[Description(@"Type of customer device.")]
[DerivedFrom(typeof(CustomerDeviceTypeCode))]
public enum CustomerDeviceType1Code
{
    /// <summary>
    /// Mobile phone
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_LGwDQUetEee9r7QjOdsbFw")]
    [Description(@"Mobile phone")]
    Mobile = CustomerDeviceTypeCode.Mobile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other device defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_LfTtMketEee9r7QjOdsbFw")]
    [Description(@"Other device defined at national level")]
    OtherNational = CustomerDeviceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other device defined in a private way.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_LtiWcketEee9r7QjOdsbFw")]
    [Description(@"Other device defined in a private way.")]
    OtherPrivate = CustomerDeviceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal computer
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_L6nwMketEee9r7QjOdsbFw")]
    [Description(@"Personal computer")]
    PersonalComputer = CustomerDeviceTypeCode.PersonalComputer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tablet
    /// Encoded/decoded by serializers as &quot;TBLT&quot;.
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_MSSpUketEee9r7QjOdsbFw")]
    [Description(@"Tablet")]
    Tablet = CustomerDeviceTypeCode.Tablet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-secure card reader attached to the customer device.
    /// Encoded/decoded by serializers as &quot;NSCR&quot;.
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_MieKIS7TEemIy6A-26wnAg")]
    [Description(@"Non-secure card reader attached to the customer device.")]
    NonSecureCardReader = CustomerDeviceTypeCode.NonSecureCardReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure card reader attached to the customer device
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_Mw-gMS7TEemIy6A-26wnAg")]
    [Description(@"Secure card reader attached to the customer device")]
    SecureCardReader = CustomerDeviceTypeCode.SecureCardReader, // same ordinal as derivation source for type conversions
}
