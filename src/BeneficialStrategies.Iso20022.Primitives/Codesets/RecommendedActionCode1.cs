// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the POI system (Point Of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VZPPYRNaEfC1ZfCQz0xB3g")]
[Description(@"Type of action to be performed by the POI system (Point Of Interaction).")]
[DerivedFrom(typeof(ActionTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RecommendedActionCode1>))]
public enum RecommendedActionCode1
{
    /// <summary>
    /// Approve the transaction.
    /// Encoded/decoded by serializers as &quot;APPV&quot;.
    /// </summary>
    [EnumMember(Value = "APPV")]
    [IsoId("_VgtJURNaEfC1ZfCQz0xB3g")]
    [Description(@"Approve the transaction.")]
    Approve = ActionTypeCode.Approve, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Block the card.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_VgtJUxNaEfC1ZfCQz0xB3g")]
    [Description(@"Block the card.")]
    BlockCard = ActionTypeCode.BlockCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_VgtJVRNaEfC1ZfCQz0xB3g")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decline the transaction.
    /// Encoded/decoded by serializers as &quot;DCLN&quot;.
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_VgtJVxNaEfC1ZfCQz0xB3g")]
    [Description(@"Decline the transaction.")]
    Decline = ActionTypeCode.Decline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No reason for declining the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_VgtJWxNaEfC1ZfCQz0xB3g")]
    [Description(@"No reason for declining the transaction.")]
    NoReasonForDecline = ActionTypeCode.NoReasonForDecline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_VgtJXRNaEfC1ZfCQz0xB3g")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_VgtJWRNaEfC1ZfCQz0xB3g")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further authentication required (e.g. one-time password)
    /// Encoded/decoded by serializers as &quot;STUA&quot;.
    /// </summary>
    [EnumMember(Value = "STUA")]
    [IsoId("_VgtJYxNaEfC1ZfCQz0xB3g")]
    [Description(@"Further authentication required (e.g. one-time password)")]
    StepUpAuthentication = ActionTypeCode.StepUpAuthentication, // same ordinal as derivation source for type conversions
}
