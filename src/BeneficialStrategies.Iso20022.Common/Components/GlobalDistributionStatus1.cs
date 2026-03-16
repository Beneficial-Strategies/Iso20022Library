// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the status of the global movement.
/// </summary>
[IsoId("_Ri-zsNp-Ed-ak6NoX_4Aeg_-2092963403")]
[DisplayName("Global Distribution Status")]
public record GlobalDistributionStatus1
{
    /// <summary>
    /// Provides information about the processing status of the global movement.
    /// </summary>
    [IsoId("_Ri-zsdp-Ed-ak6NoX_4Aeg_-2010770250")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public required DistributionProcessingStatus1 ProcessedStatus { get; init; }

    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Ri-zstp-Ed-ak6NoX_4Aeg_-2008920266")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public required DistributionRejectionStatus1 RejectedStatus { get; init; }
}
