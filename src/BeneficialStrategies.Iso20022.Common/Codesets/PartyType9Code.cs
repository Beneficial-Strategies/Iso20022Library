// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2fUvkHrTEeSfJf8ETXpBxg")]
[Description(@"Type of entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType9Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_-H_xIXrTEeSfJf8ETXpBxg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing acquiring card payment processing services on behalf on an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_-SnFsXrTEeSfJf8ETXpBxg")]
    [Description(
        @"Entity providing acquiring card payment processing services on behalf on an acquirer."
    )]
    AcquirerProcessor = PartyTypeCode.AcquirerProcessor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_-mj8cXrTEeSfJf8ETXpBxg")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as &quot;CISP&quot;.
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_-v1NMXrTEeSfJf8ETXpBxg")]
    [Description(
        @"Entity providing issuing card payment processing services on behalf on an issuer."
    )]
    CardIssuerProcessor = PartyTypeCode.CardIssuerProcessor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;CSCH&quot;.
    /// </summary>
    [EnumMember(Value = "CSCH")]
    [IsoId("_-5uJAXrTEeSfJf8ETXpBxg")]
    [Description(
        @"Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer."
    )]
    CardScheme = PartyTypeCode.CardScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting on behalf of a card scheme.
    /// Encoded/decoded by serializers as &quot;SCHP&quot;.
    /// </summary>
    [EnumMember(Value = "SCHP")]
    [IsoId("_AAaEQXrUEeSfJf8ETXpBxg")]
    [Description(
        @"Entity providing card payment processing services acting on behalf of a card scheme."
    )]
    CardSchemeProcessor = PartyTypeCode.CardSchemeProcessor, // same ordinal as derivation source for type conversions
}
