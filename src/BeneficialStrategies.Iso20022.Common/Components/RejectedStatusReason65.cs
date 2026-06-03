// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected instruction status.
/// </summary>
[IsoId("_EMRcnajVEfCzuLlmLrhIvA")]
[DisplayName("Rejected Status Reason65")]
public record RejectedStatusReason65
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_ETYKI6jVEfCzuLlmLrhIvA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason70Choice ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_ETYKK6jVEfCzuLlmLrhIvA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
