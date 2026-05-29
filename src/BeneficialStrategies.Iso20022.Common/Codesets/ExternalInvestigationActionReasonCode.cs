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
[IsoId("_5go_cCVAEe6EvsLBQ6cYtA")]
[Description(
    @"Specifies the requested action reason, as published in an external investigation action reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationActionReason1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationActionReasonCode>))]
public enum ExternalInvestigationActionReasonCode
{
    /// <summary>
    /// Objection is raised as the compensation amount quoted on the investigation response appears incorrect.
    /// Encoded/decoded by serializers as &quot;IRCD&quot;.
    /// </summary>
    [EnumMember(Value = "IRCD")]
    [IsoId("__-YKJNYUEe68t8Cw380-tA")]
    [Description(
        @"Objection is raised as the compensation amount quoted on the investigation response appears incorrect."
    )]
    InvestigationResponseCompensationDisputed,

    /// <summary>
    /// Objection is raised as the data provided on the investigation response is insufficent to address the original request.
    /// Encoded/decoded by serializers as &quot;IRIC&quot;.
    /// </summary>
    [EnumMember(Value = "IRIC")]
    [IsoId("__-YKJdYUEe68t8Cw380-tA")]
    [Description(
        @"Objection is raised as the data provided on the investigation response is insufficent to address the original request."
    )]
    InvestigationResponseIncomplete,

    /// <summary>
    /// Closure is requested as the investigation request has been resolved by requestor.
    /// Encoded/decoded by serializers as &quot;IRRR&quot;.
    /// </summary>
    [EnumMember(Value = "IRRR")]
    [IsoId("__-YKI9YUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request has been resolved by requestor.")]
    InvestigationRequestResolved,

    /// <summary>
    /// Closure is requested as the investigation request was sent in error.
    /// Encoded/decoded by serializers as &quot;IRSI&quot;.
    /// </summary>
    [EnumMember(Value = "IRSI")]
    [IsoId("__-YKItYUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request was sent in error.")]
    InvestigationRequestSentInError,

    /// <summary>
    /// See AdditionalInformation element for action reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__-YKJtYUEe68t8Cw380-tA")]
    [Description(@"See AdditionalInformation element for action reason.")]
    Narrative,
}
