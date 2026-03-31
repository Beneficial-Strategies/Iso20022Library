// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides status of the movement.
/// </summary>
[IsoId("_Ri-zttp-Ed-ak6NoX_4Aeg_728771721")]
[DisplayName("Corporate Movement Status")]
public record CorporateMovementStatus2
{
    /// <summary>
    /// Provides information about the processing status of the cancellation request.
    /// </summary>
    [IsoId("_Ri-zt9p-Ed-ak6NoX_4Aeg_1547012214")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public required CorporationActionMovementProcessingStatus2 ProcessedStatus { get; init; }

    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Ri-zuNp-Ed-ak6NoX_4Aeg_1559018048")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public required CorporateActionMovementRejectionStatus2 RejectedStatus { get; init; }
}
