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
[IsoId("_yH035VksEeSiQOnYSp7BZg")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod11
{
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_ylSPk1ksEeSiQOnYSp7BZg")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period4? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_ylSPm1ksEeSiQOnYSp7BZg")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period4? ActionPeriod { get; init; }

    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_ylSPo1ksEeSiQOnYSp7BZg")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period4? ParallelTradingPeriod { get; init; }
}
