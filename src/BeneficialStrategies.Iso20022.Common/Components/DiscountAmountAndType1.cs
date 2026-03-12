// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amount with a specific type.
/// </summary>
[IsoId("_tlhp8VkyEeGeoaLUQk__nA_1198616303")]
[DisplayName("Discount Amount And Type")]
public partial record DiscountAmountAndType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the amount.
    /// </summary>
    [IsoId("_tlhp8lkyEeGeoaLUQk__nA_-1773708415")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DiscountAmountType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Amount of money, which has been typed.
    /// </summary>
    [IsoId("_tlhp81kyEeGeoaLUQk__nA_879979740")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
