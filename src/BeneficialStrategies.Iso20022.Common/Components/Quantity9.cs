// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the quantity of a product in a trade transaction.
/// </summary>
[IsoId("_54vIkRrZEeOVR9VN6fAMUg")]
[DisplayName("Quantity")]
public partial record Quantity9
{
    #nullable enable
    
    /// <summary>
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [IsoId("_nbGTIBraEeOVR9VN6fAMUg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public required UnitOfMeasure3Choice_ UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_6QbP1xrZEeOVR9VN6fAMUg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Value { get; init; } 
    
    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_6QbP2RrZEeOVR9VN6fAMUg")]
    [DisplayName("Factor")]
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? Factor { get; init; } 
    
    
    #nullable disable
    
}
