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
[IsoId("_ArS1MNokEeC60axPepSq7g_727237019")]
[DisplayName("Market Identification")]
public partial record MarketIdentification13
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, eg, Electronic Trading Platforms (ECN), and unregulated markets, eg, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [IsoId("_ArS1MdokEeC60axPepSq7g_613397953")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MarketIdentification3Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [IsoId("_ArcmMNokEeC60axPepSq7g_-383674400")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MarketType12Choice_? Type { get; init; } 
    
    
    #nullable disable
    
}
