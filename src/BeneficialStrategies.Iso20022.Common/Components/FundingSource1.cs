// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Funding sources used to finance margin loans.
/// </summary>
[IsoId("_ispmcMkmEeeiAIB1i4AlQw")]
[DisplayName("Funding Source")]
public partial record FundingSource1
{
    #nullable enable
    
    /// <summary>
    /// Type of a funding used.
    /// </summary>
    [IsoId("_qdyngMkmEeeiAIB1i4AlQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FundingSourceType1Code Type { get; init; } 
    
    /// <summary>
    /// Market value of funding sources in base currency.
    /// </summary>
    [IsoId("_wcfakMkmEeeiAIB1i4AlQw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveOrHistoricCurrencyAndAmount MarketValue { get; init; } 
    
    
    #nullable disable
    
}
