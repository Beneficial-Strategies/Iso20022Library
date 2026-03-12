// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the independent amount and how it was applied in the calculation. It also provides a description of the amount type.
/// </summary>
[IsoId("_UlSuItp-Ed-ak6NoX_4Aeg_36158148")]
[DisplayName("Independent Amount")]
public partial record IndependentAmount2
{
    #nullable enable
    
    /// <summary>
    /// Description of the other amount used in the calculation of the independent amount.
    /// </summary>
    [IsoId("_UlSuI9p-Ed-ak6NoX_4Aeg_-419090839")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    /// <summary>
    /// Provides the independant amount.
    /// </summary>
    [IsoId("_UlSuJNp-Ed-ak6NoX_4Aeg_729114902")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Determines how the independent amount was applied in the calculation. 
    /// It is either:
    /// - before threshold, effectively acting as an add on to exposure, 
    /// - after threshold where the amount is an add on to the credit support amount and forms part of the variation margin requirement,
    /// - segregated where it is treated independently of variation margin for segregation purposes.
    /// </summary>
    [IsoId("_UlSuJdp-Ed-ak6NoX_4Aeg_186129818")]
    [DisplayName("Convention")]
    [IsoXmlTag("Cnvntn")]
    public required IndependentAmountConventionType1Code Convention { get; init; } 
    
    
    #nullable disable
    
}
