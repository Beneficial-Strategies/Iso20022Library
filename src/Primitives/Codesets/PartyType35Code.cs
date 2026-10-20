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
[IsoId("_7HmDEZ_sEfC4Q_xhaK1hdQ")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PartyType35Code>))]
public enum PartyType35Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_7IhQJZ_sEfC4Q_xhaK1hdQ")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_7IhQKZ_sEfC4Q_xhaK1hdQ")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_7IhQK5_sEfC4Q_xhaK1hdQ")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_7IhQLZ_sEfC4Q_xhaK1hdQ")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_7IhQJ5_sEfC4Q_xhaK1hdQ")]
    [Description(@"Party acting on behalf of other parties to process or forward data to other parties.")]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_7IhQI5_sEfC4Q_xhaK1hdQ")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Marketplace providing payment acceptance services on behalf of a merchant.
    /// Encoded/decoded by serializers as &quot;MKTP&quot;.
    /// </summary>
    [EnumMember(Value = "MKTP")]
    [IsoId("_Ic52UZ_4EfC4Q_xhaK1hdQ")]
    [Description(@"Marketplace providing payment acceptance services on behalf of a merchant.")]
    Marketplace = PartyTypeCode.Marketplace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_7IhQIZ_sEfC4Q_xhaK1hdQ")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment facilitator providing payment acceptance services on behalf of a merchant.
    /// Encoded/decoded by serializers as &quot;PFAC&quot;.
    /// </summary>
    [EnumMember(Value = "PFAC")]
    [IsoId("_1E65QbaFEfCUZfsQO4rYeA")]
    [Description(@"Payment facilitator providing payment acceptance services on behalf of a merchant.")]
    PaymentFacilitator = PartyTypeCode.PaymentFacilitator, // same ordinal as derivation source for type conversions
}
