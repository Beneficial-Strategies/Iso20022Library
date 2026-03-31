// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Recommended action for the issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jaoKQHsNEeSR68OJvMfxJQ")]
[Description(@"Recommended action for the issuer.")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType4Code>))]
#endif
public enum ActionType4Code
{
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_886RsXsNEeSR68OJvMfxJQ")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_-W7YoXsNEeSR68OJvMfxJQ")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_-k7_cXsNEeSR68OJvMfxJQ")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Approve the transaction.
    /// Encoded/decoded by serializers as &quot;APPV&quot;.
    /// </summary>
    [EnumMember(Value = "APPV")]
    [IsoId("_S_kQQS6qEeWc7f-D6ByqMg")]
    [Description(@"Approve the transaction.")]
    Approve = ActionTypeCode.Approve, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Block the card.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_TcMh4S6qEeWc7f-D6ByqMg")]
    [Description(@"Block the card.")]
    BlockCard = ActionTypeCode.BlockCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No reason for declining the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_UMkO4S6qEeWc7f-D6ByqMg")]
    [Description(@"No reason for declining the transaction.")]
    NoReasonForDecline = ActionTypeCode.NoReasonForDecline, // same ordinal as derivation source for type conversions
}
