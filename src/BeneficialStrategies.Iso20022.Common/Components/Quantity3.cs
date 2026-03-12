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
[IsoId("_Sqgcfdp-Ed-ak6NoX_4Aeg_-119892077")]
[DisplayName("Quantity")]
public partial record Quantity3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unit of measurement. For example, kilo, tons.
    /// </summary>
    [IsoId("_Sqgcftp-Ed-ak6NoX_4Aeg_-119891985")]
    [DisplayName("Unit Of Measure Code")]
    [IsoXmlTag("UnitOfMeasrCd")]
    public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
    
    /// <summary>
    /// Identifies the unit of measure not present in the code list.
    /// </summary>
    [IsoId("_SqpmYNp-Ed-ak6NoX_4Aeg_-119891677")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OtherUnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_SqpmYdp-Ed-ak6NoX_4Aeg_-119892046")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Value { get; init; } 
    
    
    #nullable disable
    
}
