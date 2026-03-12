// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_r1VU0S0xEeSRe9rElPHBfg")]
[DisplayName("Market Identification")]
public partial record MarketIdentification84
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, that is, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [IsoId("_sIEqpS0xEeSRe9rElPHBfg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MarketIdentification1Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [IsoId("_sIEqrS0xEeSRe9rElPHBfg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarketType8Choice_ Type { get; init; } 
    
    
    #nullable disable
    
}
