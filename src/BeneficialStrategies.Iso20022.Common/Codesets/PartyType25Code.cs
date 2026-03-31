// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity submitting a card fraud report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bs2o4XbLEeef9c2nwgY9Xw")]
[Description(@"Type of entity submitting a card fraud report.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType25Code>))]
#endif
public enum PartyType25Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_b4ppMXbLEeef9c2nwgY9Xw")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_b4ppM3bLEeef9c2nwgY9Xw")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;CSCH&quot;.
    /// </summary>
    [EnumMember(Value = "CSCH")]
    [IsoId("_b4ppNXbLEeef9c2nwgY9Xw")]
    [Description(
        @"Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer."
    )]
    CardScheme = PartyTypeCode.CardScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_b4ppN3bLEeef9c2nwgY9Xw")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_k4eq8XbLEeef9c2nwgY9Xw")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_lDV3IXbLEeef9c2nwgY9Xw")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
