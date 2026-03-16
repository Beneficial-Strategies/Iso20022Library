// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Percentage Price3.
/// </summary>
[IsoId("_jiaMUYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Percentage Price3")]
public partial record PercentagePrice3
{
    #nullable enable

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

    
    #nullable disable
    
}
