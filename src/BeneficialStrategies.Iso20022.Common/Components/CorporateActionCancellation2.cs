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
[IsoId("_WbT0ktp-Ed-ak6NoX_4Aeg_-826619603")]
[DisplayName("Corporate Action Cancellation")]
public record CorporateActionCancellation2
{
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    [IsoId("_WbT0k9p-Ed-ak6NoX_4Aeg_-190792293")]
    [DisplayName("Cancellation Reason Code")]
    [IsoXmlTag("CxlRsnCd")]
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; }

    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    [IsoId("_WbT0lNp-Ed-ak6NoX_4Aeg_1001393480")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? CancellationReason { get; init; }

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_WbT0ldp-Ed-ak6NoX_4Aeg_1330542906")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; }
}
