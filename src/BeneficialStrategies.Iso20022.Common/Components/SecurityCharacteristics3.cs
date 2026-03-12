// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information about the security.
/// </summary>
[IsoId("_f2gQwTpyEemk2e6qGBk8IQ")]
[DisplayName("Security Characteristics")]
public partial record SecurityCharacteristics3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as known by the account owner, to unambiguously identify the security.
    /// </summary>
    [IsoId("_gGvsMTpyEemk2e6qGBk8IQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public SecurityIdentification19? Identification { get; init; } 
    
    /// <summary>
    /// Specifies the position for the security.
    /// </summary>
    [IsoId("_gGvsMzpyEemk2e6qGBk8IQ")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    public SecuritiesPosition1? Position { get; init; } 
    
    /// <summary>
    /// Specifies the price of the security for valuation purposes.
    /// </summary>
    [IsoId("_gGvsNTpyEemk2e6qGBk8IQ")]
    [DisplayName("Valuation Price")]
    [IsoXmlTag("ValtnPric")]
    public required AmountPricePerFinancialInstrumentQuantity9 ValuationPrice { get; init; } 
    
    /// <summary>
    /// Specifies the value of the security for collateral purposes.
    /// </summary>
    [IsoId("_gGvsNzpyEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    
    #nullable disable
    
}
