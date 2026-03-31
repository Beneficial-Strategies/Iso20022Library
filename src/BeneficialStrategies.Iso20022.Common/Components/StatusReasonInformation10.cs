// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the instruction.
/// </summary>
[IsoId("_kpLGou5NEeCisYr99QEiWA_743644615")]
[DisplayName("Status Reason Information")]
public record StatusReasonInformation10
{
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_kpLGo-5NEeCisYr99QEiWA_-457987999")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required StatusReason6Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_kpLGpO5NEeCisYr99QEiWA_-693026204")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
