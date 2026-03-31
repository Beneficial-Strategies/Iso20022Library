// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card security code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zyCVQJiuEeefZKJHxQTztg")]
[Description(@"Card security code list.")]
[DerivedFrom(typeof(CardSecurityCapabilityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardSecurityCapability1Code>))]
#endif
public enum CardSecurityCapability1Code
{
    /// <summary>
    /// Card contains an integrated circuit card.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_19rGYZiuEeefZKJHxQTztg")]
    [Description(@"Card contains an integrated circuit card.")]
    ICC = CardSecurityCapabilityCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card does not contain a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MWOS&quot;.
    /// </summary>
    [EnumMember(Value = "MWOS")]
    [IsoId("_2MaF8piuEeefZKJHxQTztg")]
    [Description(@"Card does not contain a card security code in the magstripe")]
    MagneticStripeWithoutSecurityCode =
        CardSecurityCapabilityCode.MagneticStripeWithoutSecurityCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card contains a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MSWS&quot;.
    /// </summary>
    [EnumMember(Value = "MSWS")]
    [IsoId("_2ZZZEpiuEeefZKJHxQTztg")]
    [Description(@"Card contains a card security code in the magstripe")]
    MagneticStripeWithSecurityCode = CardSecurityCapabilityCode.MagneticStripeWithSecurityCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of card defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_2mahYpiuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at national level.")]
    OtherNational = CardSecurityCapabilityCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of card defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_24fI0piuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at private level.")]
    OtherPrivate = CardSecurityCapabilityCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off line PIN card
    /// Encoded/decoded by serializers as &quot;OLPN&quot;.
    /// </summary>
    [EnumMember(Value = "OLPN")]
    [IsoId("_5L7VoZivEeefZKJHxQTztg")]
    [Description(@"Off line PIN card")]
    OffLinePIN = CardSecurityCapabilityCode.OffLinePIN, // same ordinal as derivation source for type conversions
}
