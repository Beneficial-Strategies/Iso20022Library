// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of role assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QGY4gEqLEeenp6hmNprBHg")]
[Description(@"Type of role assigned.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType17Code>))]
#endif
public enum PartyType17Code
{
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_T1iDwUqLEeenp6hmNprBHg")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_UBmw4UqLEeenp6hmNprBHg")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_VNeHEUqLEeenp6hmNprBHg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing acquiring card payment processing services on behalf on an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_VcQxAUqLEeenp6hmNprBHg")]
    [Description(
        @"Entity providing acquiring card payment processing services on behalf on an acquirer."
    )]
    AcquirerProcessor = PartyTypeCode.AcquirerProcessor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_WAHE8UqLEeenp6hmNprBHg")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as &quot;CISP&quot;.
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_WM15YUqLEeenp6hmNprBHg")]
    [Description(
        @"Entity providing issuing card payment processing services on behalf on an issuer."
    )]
    CardIssuerProcessor = PartyTypeCode.CardIssuerProcessor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_XcCQYUqLEeenp6hmNprBHg")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
}
