// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_HPltAQc_EeSyIPzOZ6VzBQ")]
[DisplayName("Unit Price")]
public record UnitPrice19
{
    /// <summary>
    /// Type of price.
    /// </summary>
    [IsoId("_Hp64kQc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public required UnitPriceType2Choice_ PriceType { get; init; }

    /// <summary>
    /// Value of the price, that is, as a currency and value.
    /// </summary>
    [IsoId("_Hp64kwc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; }
}
