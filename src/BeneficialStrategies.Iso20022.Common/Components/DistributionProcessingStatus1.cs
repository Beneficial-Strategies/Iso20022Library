// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the processing status of a global movement.
/// </summary>
[IsoId("_RlXZVdp-Ed-ak6NoX_4Aeg_-2044015905")]
[DisplayName("Distribution Processing Status")]
public record DistributionProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RlXZVtp-Ed-ak6NoX_4Aeg_-1653366101")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus3FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlXZV9p-Ed-ak6NoX_4Aeg_-1653366071")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
