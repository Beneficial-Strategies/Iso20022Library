// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card domain type of party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VnZwkE0pEeea0Mdu1TOzDQ")]
[Description(@"Card domain type of party.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType20Code>))]
#endif
public enum PartyType20Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_d0zP0U0pEeea0Mdu1TOzDQ")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_hILFEk0pEeea0Mdu1TOzDQ")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holder of a payment card.
    /// Encoded/decoded by serializers as &quot;CRDH&quot;.
    /// </summary>
    [EnumMember(Value = "CRDH")]
    [IsoId("_hxsjMU0pEeea0Mdu1TOzDQ")]
    [Description(@"Holder of a payment card.")]
    Cardholder = PartyTypeCode.Cardholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_i0EmMk0pEeea0Mdu1TOzDQ")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_nvk8AZmKEee_M7tURHTZTQ")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
}
