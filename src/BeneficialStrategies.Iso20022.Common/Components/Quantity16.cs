// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the quantity of a product in a trade transaction.
/// </summary>
[IsoId("_GYSbcfFTEee_LsXdoqzkWg")]
[DisplayName("Quantity")]
public record Quantity16
{
    /// <summary>
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [IsoId("_GhFLEfFTEee_LsXdoqzkWg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public required UnitOfMeasure6Choice_ UnitOfMeasure { get; init; }

    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_GhFLE_FTEee_LsXdoqzkWg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Value { get; init; }

    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_GhFLFfFTEee_LsXdoqzkWg")]
    [DisplayName("Factor")]
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? Factor { get; init; }
}
