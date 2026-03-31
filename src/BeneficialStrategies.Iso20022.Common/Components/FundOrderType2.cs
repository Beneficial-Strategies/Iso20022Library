// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[IsoId("_TSu6GNp-Ed-ak6NoX_4Aeg_1291775192")]
[DisplayName("Fund Order Type")]
public record FundOrderType2
{
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6Gdp-Ed-ak6NoX_4Aeg_1790476155")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public required FundOrderType3Code OrderType { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_TSu6Gtp-Ed-ak6NoX_4Aeg_1790476190")]
    [DisplayName("Extended Order Type")]
    [IsoXmlTag("XtndedOrdrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOrderType { get; init; }
}
