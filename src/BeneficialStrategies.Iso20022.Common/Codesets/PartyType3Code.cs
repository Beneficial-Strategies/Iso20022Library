// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTjgTQEcEeCQm6a_G2yO_w_-438078851")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType3Code>))]
#endif
public enum PartyType3Code
{
    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_TTjgTgEcEeCQm6a_G2yO_w_-1194753153")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TTjgTwEcEeCQm6a_G2yO_w_-612106672")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_TTjgUAEcEeCQm6a_G2yO_w_1684002543")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_TTjgUQEcEeCQm6a_G2yO_w_1672903766")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_TTjgUgEcEeCQm6a_G2yO_w_1998021273")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_TTjgUwEcEeCQm6a_G2yO_w_946955618")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_TTjgVAEcEeCQm6a_G2yO_w_-560697087")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions
}
