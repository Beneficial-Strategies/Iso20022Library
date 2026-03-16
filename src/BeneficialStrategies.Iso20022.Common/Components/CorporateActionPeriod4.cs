// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods.
/// </summary>
[IsoId("_TWTyhtp-Ed-ak6NoX_4Aeg_277626212")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod4
{
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_TWTyh9p-Ed-ak6NoX_4Aeg_277626243")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period3? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_TWTyiNp-Ed-ak6NoX_4Aeg_277626544")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period3? ActionPeriod { get; init; }

    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_TWTyidp-Ed-ak6NoX_4Aeg_277626513")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period3? ParallelTradingPeriod { get; init; }
}
