// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about actions that may be taken on an account.
/// </summary>
[IsoId("_TCoJUe6SEemVDc1WJaqofw")]
[DisplayName("Investor Profile")]
public partial record InvestorProfile2
{
    #nullable enable
    
    /// <summary>
    /// Type of profile.
    /// </summary>
    [IsoId("_TXAd4e6SEemVDc1WJaqofw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ProfileType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Status of the profile.
    /// </summary>
    [IsoId("_TXAd4-6SEemVDc1WJaqofw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public InvestorProfileStatus1Choice_? Status { get; init; } 
    
    /// <summary>
    /// Information about the profile for treasury trading.
    /// </summary>
    [IsoId("_TXAd5e6SEemVDc1WJaqofw")]
    [DisplayName("Treasury")]
    [IsoXmlTag("Trsr")]
    public TreasuryProfile1? Treasury { get; init; } 
    
    /// <summary>
    /// Information about the profile for high frequency trading.
    /// </summary>
    [IsoId("_TXAd5-6SEemVDc1WJaqofw")]
    [DisplayName("High Frequency Trading")]
    [IsoXmlTag("HghFrqcyTradg")]
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; init; } 
    
    /// <summary>
    /// Information about the profile for a market marker.
    /// </summary>
    [IsoId("_TXAd6e6SEemVDc1WJaqofw")]
    [DisplayName("Market Maker")]
    [IsoXmlTag("MktMakr")]
    public MarketMakerProfile2? MarketMaker { get; init; } 
    
    
    #nullable disable
    
}
