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
[IsoId("_qLqWUTAPEeOKib24wnHaFg")]
[DisplayName("Quantity")]
public partial record Quantity10
{
    #nullable enable
    
    /// <summary>
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [IsoId("_5ze_wDAPEeOKib24wnHaFg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public required UnitOfMeasure3Choice_ UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_qrwLpzAPEeOKib24wnHaFg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Value { get; init; } 
    
    
    #nullable disable
    
}
