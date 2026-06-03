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
[IsoId("_wv-WEaKsEfCHi7w3_0pcpw")]
[DisplayName("Rejected Status Reason63")]
public record RejectedStatusReason63
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_w2X5A6KsEfCHi7w3_0pcpw")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason68Choice ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_w2X5C6KsEfCHi7w3_0pcpw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
