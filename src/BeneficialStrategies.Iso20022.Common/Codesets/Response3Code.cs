// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the request message or advice message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nY5LoHuGEeSZrqGdHyoIrw")]
[Description(@"Result of the request message or advice message.")]
[DerivedFrom(typeof(ResponseCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Response3Code>))]
#endif
public enum Response3Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_p-IvkXuGEeSZrqGdHyoIrw")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_qEZIkXuGEeSZrqGdHyoIrw")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further action required to complete the transaction, for instance a referral.
    /// Encoded/decoded by serializers as &quot;FRTH&quot;.
    /// </summary>
    [EnumMember(Value = "FRTH")]
    [IsoId("_qMJWYXuGEeSZrqGdHyoIrw")]
    [Description(@"Further action required to complete the transaction, for instance a referral.")]
    FurtherAction = ResponseCode.FurtherAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_rHtmwXuGEeSZrqGdHyoIrw")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice message is processed.
    /// Encoded/decoded by serializers as &quot;PRCS&quot;.
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_rPm-gXuGEeSZrqGdHyoIrw")]
    [Description(@"Advice message is processed.")]
    Processed = ResponseCode.Processed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice message could not be processed.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_QgeH4SxKEeW0Obqrzm1X8Q")]
    [Description(@"Advice message could not be processed.")]
    NotProcessed = ResponseCode.NotProcessed, // same ordinal as derivation source for type conversions
}
