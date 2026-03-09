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
/// Provides the details for negotiating and trading a large number of securities contained in or comprising a portfolio. ||One example is index arbitrage, which consists in the purchase or sale of a basket of stocks in conjunction with the sale or purchase of|a derivative product (for example index futures) to profit from price differences between the basket and the derivative product. ||Other examples include liquidation of EFP (Exchange for Physical) stock positions, portfolio realignment and portfolio liquidation.
/// </summary>
[IsoId("_SzmHAtp-Ed-ak6NoX_4Aeg_-606838649")]
[DisplayName("List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record List2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a List2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public List2( System.String reqListIdentification )
    {
        ListIdentification = reqListIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHA9p-Ed-ak6NoX_4Aeg_-565279150")]
    [DisplayName("List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListId")]
    #endif
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ListIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ListIdentification { get; init; } 
    #else
    public System.String ListIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    [IsoId("_SzmHBNp-Ed-ak6NoX_4Aeg_-239278735")]
    [DisplayName("Trade Origination Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradOrgtnDtTm")]
    #endif
    [IsoXmlTag("TradOrgtnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradeOriginationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradeOriginationDateTime { get; init; } 
    #else
    public System.DateTime? TradeOriginationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_SzmHBdp-Ed-ak6NoX_4Aeg_-1356753745")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradeDate { get; init; } 
    #else
    public System.DateTime? TradeDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
