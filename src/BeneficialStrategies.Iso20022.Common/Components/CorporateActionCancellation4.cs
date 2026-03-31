// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event cancellation status and reason.
/// </summary>
[IsoId("_TdbKmVAeEeO1M--XQMqOtA")]
[DisplayName("Corporate Action Cancellation")]
public record CorporateActionCancellation4
{
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    [IsoId("_TdbKm1AeEeO1M--XQMqOtA")]
    [DisplayName("Cancellation Reason Code")]
    [IsoXmlTag("CxlRsnCd")]
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; }

    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    [IsoId("_TdbKo1AeEeO1M--XQMqOtA")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? CancellationReason { get; init; }

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_TdbKq1AeEeO1M--XQMqOtA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionEventStatus1 ProcessingStatus { get; init; }
}
