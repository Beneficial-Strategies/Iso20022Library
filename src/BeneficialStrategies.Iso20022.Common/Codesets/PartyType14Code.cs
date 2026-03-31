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
[IsoId("_yq2IkY0YEeWRYffwL7E13A")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType14Code>))]
#endif
public enum PartyType14Code
{
    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_y13s0Y0YEeWRYffwL7E13A")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_y13s040YEeWRYffwL7E13A")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_y13s1Y0YEeWRYffwL7E13A")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_y13s140YEeWRYffwL7E13A")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_y13s2Y0YEeWRYffwL7E13A")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_y13s240YEeWRYffwL7E13A")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_y13s3Y0YEeWRYffwL7E13A")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_3vj_oY0YEeWRYffwL7E13A")]
    [Description(@"Application in the smart card.")]
    CardApplication = PartyTypeCode.CardApplication, // same ordinal as derivation source for type conversions
}
