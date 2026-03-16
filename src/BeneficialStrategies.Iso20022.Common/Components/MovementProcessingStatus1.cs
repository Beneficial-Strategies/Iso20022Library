// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the processing status of an individual movement.
/// </summary>
[IsoId("_RlNoUtp-Ed-ak6NoX_4Aeg_-1325784757")]
[DisplayName("Movement Processing Status")]
public record MovementProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RlNoU9p-Ed-ak6NoX_4Aeg_-1310083491")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus3FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlNoVNp-Ed-ak6NoX_4Aeg_-1310083490")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
