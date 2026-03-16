// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an in repair status.
/// </summary>
[IsoId("_UuFdwdp-Ed-ak6NoX_4Aeg_-1969521275")]
[DisplayName("In Repair Status Reason")]
public record InRepairStatusReason2
{
    /// <summary>
    /// Reason for the in repair status in textual form.
    /// </summary>
    [IsoId("_UuFdwtp-Ed-ak6NoX_4Aeg_-1922423004")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
