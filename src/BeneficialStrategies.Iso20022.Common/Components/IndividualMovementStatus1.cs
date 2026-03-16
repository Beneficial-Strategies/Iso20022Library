// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the processing status.
/// </summary>
[IsoId("_RjkpkNp-Ed-ak6NoX_4Aeg_-1988452432")]
[DisplayName("Individual Movement Status")]
public record IndividualMovementStatus1
{
    /// <summary>
    /// Identification of the movement.
    /// </summary>
    [IsoId("_Rjkpkdp-Ed-ak6NoX_4Aeg_-1957054674")]
    [DisplayName("Movement Identification")]
    [IsoXmlTag("MvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MovementIdentification { get; init; }

    /// <summary>
    /// Provides information about the processing status of individual movement.
    /// </summary>
    [IsoId("_Rjkpktp-Ed-ak6NoX_4Aeg_-1443576010")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public required MovementProcessingStatus1 ProcessedStatus { get; init; }

    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Rjkpk9p-Ed-ak6NoX_4Aeg_1990813693")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public required DistributionRejectionStatus1 RejectedStatus { get; init; }
}
