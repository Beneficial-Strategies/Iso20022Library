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
[IsoId("_PrNlGrKbEemux5trsZcCpw")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason27
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_PrNlHLKbEemux5trsZcCpw")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason28Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_PrNlHbKbEemux5trsZcCpw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
