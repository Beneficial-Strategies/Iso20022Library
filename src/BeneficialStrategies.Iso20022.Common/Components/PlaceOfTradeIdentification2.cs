// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of market in which a trade transaction has been executed.
/// </summary>
[IsoId("_UzQfUZkBEeWn2ur3BXxtdg")]
[DisplayName("Place Of Trade Identification")]
public partial record PlaceOfTradeIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification and type of the place of trade.
    /// </summary>
    [IsoId("_VClUwZkBEeWn2ur3BXxtdg")]
    [DisplayName("Market Type And Identification")]
    [IsoXmlTag("MktTpAndId")]
    public MarketIdentification90? MarketTypeAndIdentification { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a place of trade.
    /// </summary>
    [IsoId("_VClUw5kBEeWn2ur3BXxtdg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
