// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of role assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ewumAEqLEeenp6hmNprBHg")]
[Description(@"Type of role assigned.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType18Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_kWWKsUqLEeenp6hmNprBHg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_lyQIAUqLEeenp6hmNprBHg")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;CSCH&quot;.
    /// </summary>
    [EnumMember(Value = "CSCH")]
    [IsoId("_l_O0EUqLEeenp6hmNprBHg")]
    [Description(
        @"Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer."
    )]
    CardScheme = PartyTypeCode.CardScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_pSO14UqLEeenp6hmNprBHg")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
}
