// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Percentage Price2.
/// </summary>
[IsoId("_CkPiUYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Percentage Price2")]
public record PercentagePrice2
{
    /// <summary>
    /// Percentage Price Type.
    /// </summary>
    [DisplayName("Percentage Price Type")]
    [IsoXmlTag("PctgPricTp")]
    public required PriceRateType3Code PercentagePriceType { get; init; }

    /// <summary>
    /// Price Value.
    /// </summary>
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required IsoPercentage14Rate PriceValue { get; init; }
}
