// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the rejection reason of an individual element.
/// </summary>
[IsoId("_RJy3pdp-Ed-ak6NoX_4Aeg_2106998089")]
[DisplayName("Rejected Element")]
public record RejectedElement1
{
    /// <summary>
    /// Sequence number that allows to easily identify the element that is rejected.
    /// </summary>
    [IsoId("_RJy3ptp-Ed-ak6NoX_4Aeg_-1803784041")]
    [DisplayName("Element Sequence Number")]
    [IsoXmlTag("ElmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ElementSequenceNumber { get; init; }

    /// <summary>
    /// Reason for rejecting an individual element.
    /// </summary>
    [IsoId("_RJy3p9p-Ed-ak6NoX_4Aeg_1481340627")]
    [DisplayName("Individual Rejection Reason")]
    [IsoXmlTag("IndvRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text IndividualRejectionReason { get; init; }
}
