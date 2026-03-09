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
[IsoId("_S07jwdp-Ed-ak6NoX_4Aeg_986706325")]
[DisplayName("Non Disclosed Bid")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonDisclosedBid2
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
    [IsoId("_S07jwtp-Ed-ak6NoX_4Aeg_1205583746")]
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
    [IsoId("_S07jw9p-Ed-ak6NoX_4Aeg_1206503753")]
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
    [IsoId("_S07jxNp-Ed-ak6NoX_4Aeg_1206503778")]
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
    /// Difference between the value of a future and the value of the underlying equities after allowing for the discounted cash flows associated with the underlying stocks.
    /// </summary>
    [IsoId("_S07jxdp-Ed-ak6NoX_4Aeg_-1304220816")]
    [DisplayName("Fair Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FairVal")]
    #endif
    [IsoXmlTag("FairVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FairValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
