// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about actions that may be taken on an account.
/// </summary>
[IsoId("_WK6_oCDNEeWPMvNwVtiMsA")]
[DisplayName("Investor Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestorProfile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of profile.
    /// </summary>
    [IsoId("_rSMUUCDNEeWPMvNwVtiMsA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProfileType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProfileType1Choice_? Type { get; init; } 
    #else
    public ProfileType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the profile.
    /// </summary>
    [IsoId("_k6XaICDOEeWPMvNwVtiMsA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorProfileStatus1Choice_? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorProfileStatus1Choice_? Status { get; init; } 
    #else
    public InvestorProfileStatus1Choice_? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the profile for treasury trading.
    /// </summary>
    [IsoId("__bXFMCDREeWCLu74WLgP4w")]
    [DisplayName("Treasury")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trsr")]
    #endif
    [IsoXmlTag("Trsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TreasuryProfile1? Treasury { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TreasuryProfile1? Treasury { get; init; } 
    #else
    public TreasuryProfile1? Treasury { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the profile for high frequency trading.
    /// </summary>
    [IsoId("_GDj2UCDUEeWCLu74WLgP4w")]
    [DisplayName("High Frequency Trading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghFrqcyTradg")]
    #endif
    [IsoXmlTag("HghFrqcyTradg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; init; } 
    #else
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the profile for a market marker.
    /// </summary>
    [IsoId("_9tFosCDVEeWCLu74WLgP4w")]
    [DisplayName("Market Maker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktMakr")]
    #endif
    [IsoXmlTag("MktMakr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketMakerProfile1? MarketMaker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketMakerProfile1? MarketMaker { get; init; } 
    #else
    public MarketMakerProfile1? MarketMaker { get; set; } 
    #endif
    
    
    #nullable disable
    
}
