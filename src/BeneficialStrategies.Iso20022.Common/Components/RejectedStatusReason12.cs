// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
[IsoId("_qopB-lj7EeOgwYxfAV02bg")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason12
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_qopCAFj7EeOgwYxfAV02bg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedReason8Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    [IsoId("_qopB-1j7EeOgwYxfAV02bg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
