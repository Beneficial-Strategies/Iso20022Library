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
/// List trading by which the buy-side provides details to the sell-side information about the sector, country, index and potential market impact of the financial instrument to be bought or sold. Using this information, the sell-side firms bid for the trade.
/// </summary>
[IsoId("_S0yZ2tp-Ed-ak6NoX_4Aeg_1294975941")]
[DisplayName("Non Disclosed Bid")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonDisclosedBid1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the currency) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ29p-Ed-ak6NoX_4Aeg_1391021740")]
    [DisplayName("Bid By Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidByCcy")]
    #endif
    [IsoXmlTag("BidByCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? BidByCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BidByCurrency { get; init; } 
    #else
    public string? BidByCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the sector) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ3Np-Ed-ak6NoX_4Aeg_1391021783")]
    [DisplayName("Bid By Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidBySctr")]
    #endif
    [IsoXmlTag("BidBySctr")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax128Text? BidBySector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BidBySector { get; init; } 
    #else
    public System.String? BidBySector { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the index) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ3dp-Ed-ak6NoX_4Aeg_1391021801")]
    [DisplayName("Bid By Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidByIndx")]
    #endif
    [IsoXmlTag("BidByIndx")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax128Text? BidByIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BidByIndex { get; init; } 
    #else
    public System.String? BidByIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the side of the bid in the case of a non disclosed bidding process. Used instead of buy and sell side.|True = Side 1|False = Side 2.
    /// </summary>
    [IsoId("_S0yZ3tp-Ed-ak6NoX_4Aeg_1130979716")]
    [DisplayName("Side Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdInd")]
    #endif
    [IsoXmlTag("SdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SideIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SideIndicator { get; init; } 
    #else
    public System.String? SideIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additionnal details about the liquidity of a financial instrument.
    /// </summary>
    [IsoId("_S0yZ39p-Ed-ak6NoX_4Aeg_1163301984")]
    [DisplayName("Liquidity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lqdty")]
    #endif
    [IsoXmlTag("Lqdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Liquidity1? Liquidity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Liquidity1? Liquidity { get; init; } 
    #else
    public Liquidity1? Liquidity { get; set; } 
    #endif
    
    /// <summary>
    /// Details about the exchange for physical trade parameters.
    /// </summary>
    [IsoId("_S07jwNp-Ed-ak6NoX_4Aeg_-1312987174")]
    [DisplayName("Exchange For Physical Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgForPhysTrad")]
    #endif
    [IsoXmlTag("XchgForPhysTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeForPhysicalTradeParameters1? ExchangeForPhysicalTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeForPhysicalTradeParameters1? ExchangeForPhysicalTrade { get; init; } 
    #else
    public ExchangeForPhysicalTradeParameters1? ExchangeForPhysicalTrade { get; set; } 
    #endif
    
    
    #nullable disable
    
}
