// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of the commodity.
/// </summary>
[IsoId("_jOPbKaocEemdLtwzt4CWxg")]
[DisplayName("Quantity")]
public record Quantity17
{
    /// <summary>
    /// Fair value of the individual collateral component expressed in price currency.
    /// </summary>
    [IsoId("_jRzsgaocEemdLtwzt4CWxg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Value { get; init; }

    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_jRzsg6ocEemdLtwzt4CWxg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public required UnitOfMeasure11Code UnitOfMeasure { get; init; }
}
