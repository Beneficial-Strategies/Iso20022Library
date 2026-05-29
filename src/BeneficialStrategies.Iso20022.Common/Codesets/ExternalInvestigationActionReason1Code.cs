// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the requested action reason, as published in an external investigation action reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HV6GICVBEe6EvsLBQ6cYtA")]
[Description(
    @"Specifies the requested action reason, as published in an external investigation action reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationActionReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationActionReason1Code>))]
public enum ExternalInvestigationActionReason1Code
{
    /// <summary>
    /// Objection is raised as the compensation amount quoted on the investigation response appears incorrect.
    /// Encoded/decoded by serializers as &quot;IRCD&quot;.
    /// </summary>
    [EnumMember(Value = "IRCD")]
    [IsoId("___Q6-9YUEe68t8Cw380-tA")]
    [Description(
        @"Objection is raised as the compensation amount quoted on the investigation response appears incorrect."
    )]
    InvestigationResponseCompensationDisputed = ExternalInvestigationActionReasonCode.InvestigationResponseCompensationDisputed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Objection is raised as the data provided on the investigation response is insufficent to address the original request.
    /// Encoded/decoded by serializers as &quot;IRIC&quot;.
    /// </summary>
    [EnumMember(Value = "IRIC")]
    [IsoId("___Q6_dYUEe68t8Cw380-tA")]
    [Description(
        @"Objection is raised as the data provided on the investigation response is insufficent to address the original request."
    )]
    InvestigationResponseIncomplete = ExternalInvestigationActionReasonCode.InvestigationResponseIncomplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closure is requested as the investigation request has been resolved by requestor.
    /// Encoded/decoded by serializers as &quot;IRRR&quot;.
    /// </summary>
    [EnumMember(Value = "IRRR")]
    [IsoId("___Q6-dYUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request has been resolved by requestor.")]
    InvestigationRequestResolved = ExternalInvestigationActionReasonCode.InvestigationRequestResolved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closure is requested as the investigation request was sent in error.
    /// Encoded/decoded by serializers as &quot;IRSI&quot;.
    /// </summary>
    [EnumMember(Value = "IRSI")]
    [IsoId("___Q699YUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request was sent in error.")]
    InvestigationRequestSentInError = ExternalInvestigationActionReasonCode.InvestigationRequestSentInError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See AdditionalInformation element for action reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("___Q6_9YUEe68t8Cw380-tA")]
    [Description(@"See AdditionalInformation element for action reason.")]
    Narrative = ExternalInvestigationActionReasonCode.Narrative, // same ordinal as derivation source for type conversions
}
