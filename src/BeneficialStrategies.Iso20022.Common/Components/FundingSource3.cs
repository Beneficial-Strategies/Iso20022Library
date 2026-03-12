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
[IsoId("_Z9DqP2uBEeu7Sr851GoLXg")]
[DisplayName("Funding Source")]
public partial record FundingSource3
{
    #nullable enable
    
    /// <summary>
    /// Type of a funding used.
    /// </summary>
    [IsoId("_Z-6rYWuBEeu7Sr851GoLXg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FundingSourceType1Code Type { get; init; } 
    
    /// <summary>
    /// Market value of funding sources in base currency.
    /// </summary>
    [IsoId("_Z-6rY2uBEeu7Sr851GoLXg")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required AmountAndDirection53 MarketValue { get; init; } 
    
    
    #nullable disable
    
}
