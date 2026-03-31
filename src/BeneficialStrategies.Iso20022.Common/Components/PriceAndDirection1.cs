// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price and an indication of whether it is a increase or a decrease.
/// </summary>
[IsoId("_m-cPtfNBEeCuA5Tr22BnwA_127397945")]
[DisplayName("Price And Direction")]
public record PriceAndDirection1
{
    /// <summary>
    /// Currency and value.
    /// </summary>
    [IsoId("_m-cPtvNBEeCuA5Tr22BnwA_-1084265103")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Value { get; init; }

    /// <summary>
    /// Indicates that the value is positive or negative.
    /// </summary>
    [IsoId("_m-lZoPNBEeCuA5Tr22BnwA_1917918061")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
