// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Processing status of the corporate action notification advice coming from the issuer agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_81_WIFuwEe6gDOpEK7Q4ig")]
[Description(
    @"Processing status of the corporate action notification advice coming from the issuer agent."
)]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ProcessedStatus7Code>))]
public enum ProcessedStatus7Code
{
    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ORVysluxEe6gDOpEK7Q4ig")]
    [Description(@"The request is accepted.")]
    Accepted = CorporateActionProcessedStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_PwRO0luxEe6gDOpEK7Q4ig")]
    [Description(@"The processing of the request is pending.")]
    Pending = CorporateActionProcessedStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_J295IVuxEe6gDOpEK7Q4ig")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The advice has been sent to the market.
    /// Encoded/decoded by serializers as &quot;SENT&quot;.
    /// </summary>
    [EnumMember(Value = "SENT")]
    [IsoId("_KFkV0luxEe6gDOpEK7Q4ig")]
    [Description(@"The advice has been sent to the market.")]
    SentToMarket = CorporateActionProcessedStatusCode.SentToMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("_KQ5cEluxEe6gDOpEK7Q4ig")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable = CorporateActionProcessedStatusCode.SystemNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The announcement has been accepted but another source has provided different information.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_LEKFAluxEe6gDOpEK7Q4ig")]
    [Description(
        @"The announcement has been accepted but another source has provided different information."
    )]
    AcceptedWithWarning = CorporateActionProcessedStatusCode.AcceptedWithWarning, // same ordinal as derivation source for type conversions
}
