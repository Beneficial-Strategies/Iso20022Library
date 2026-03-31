// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Recipient of the additional information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KWN-kE9KEeeg87n1YQSQ_A")]
[Description(@"Recipient of the additional information.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType22Code>))]
#endif
public enum PartyType22Code
{
    /// <summary>
    /// Holder of a payment card.
    /// Encoded/decoded by serializers as &quot;CRDH&quot;.
    /// </summary>
    [EnumMember(Value = "CRDH")]
    [IsoId("_SVzEQU9KEeeg87n1YQSQ_A")]
    [Description(@"Holder of a payment card.")]
    Cardholder = PartyTypeCode.Cardholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_ToYGcU9KEeeg87n1YQSQ_A")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_VDFw8U9KEeeg87n1YQSQ_A")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_VQLxwU9KEeeg87n1YQSQ_A")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_jNLu4ZmKEee_M7tURHTZTQ")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
}
