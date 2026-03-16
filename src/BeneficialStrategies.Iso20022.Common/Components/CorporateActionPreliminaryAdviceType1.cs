// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_QxNYhdp-Ed-ak6NoX_4Aeg_206813968")]
[DisplayName("Corporate Action Preliminary Advice Type")]
public record CorporateActionPreliminaryAdviceType1
{
    /// <summary>
    /// Type of movement preliminary advice ie. new or replacement.
    /// </summary>
    [IsoId("_QxNYhtp-Ed-ak6NoX_4Aeg_-140554685")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; }

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_QxNYh9p-Ed-ak6NoX_4Aeg_1529675202")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Indicates whether the movement preliminary advice is sent after entitlement date.
    /// Value is Yes (true) if sent after entitlement date and No (false) if sent before entitlement date.
    /// </summary>
    [IsoId("_QxNYiNp-Ed-ak6NoX_4Aeg_-1422220686")]
    [DisplayName("Eligibility Indicator")]
    [IsoXmlTag("ElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibilityIndicator { get; init; }
}
