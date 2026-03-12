// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument that gives the holder the right to purchase shares or bonds at a given price within a specified time.
/// </summary>
[IsoId("_rfndQWf2Eembv_9KtOEw8g")]
[DisplayName("Warrant")]
public partial record Warrant4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_rsuFIWf2Eembv_9KtOEw8g")]
    [DisplayName("Multiplier")]
    [IsoXmlTag("Mltplr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? Multiplier { get; init; } 
    
    /// <summary>
    /// Pre-determined price at which the holder of a warrant is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_rsuFI2f2Eembv_9KtOEw8g")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price8? SubscriptionPrice { get; init; } 
    
    /// <summary>
    /// Indicates when a warrant can be exercised.
    /// </summary>
    [IsoId("_rsuFJWf2Eembv_9KtOEw8g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public WarrantStyle3Choice_? Type { get; init; } 
    
    /// <summary>
    /// Entity appointed by the issuer to process the exercising of warrants, sometimes responsible for the issuance of the warrants into the market.
    /// </summary>
    [IsoId("_rsuFJ2f2Eembv_9KtOEw8g")]
    [DisplayName("Warrant Agent")]
    [IsoXmlTag("WarrtAgt")]
    public Organisation38? WarrantAgent { get; init; } 
    
    
    #nullable disable
    
}
