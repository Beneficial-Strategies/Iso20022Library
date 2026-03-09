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
/// Details of the foreign exchange trade including spot\forward\NDF\swap that is confirmed.
/// </summary>
[IsoId("_yDLnEA2IEeSwB74WgTbh4Q")]
[DisplayName("Trade")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Trade2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Trade2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Trade2( System.String reqTradeIdentification,System.DateOnly reqTradeDate,UnderlyingProductIdentifier1Code reqForeignExchangeTradeProduct,TradingModeType1Code reqTradingMode,ClearingMethod1Code reqClearingMethod )
    {
        TradeIdentification = reqTradeIdentification;
        TradeDate = reqTradeDate;
        ForeignExchangeTradeProduct = reqForeignExchangeTradeProduct;
        TradingMode = reqTradingMode;
        ClearingMethod = reqClearingMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_6QrTkBkmEeSmqJmZFbWcmQ")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeIdentification { get; init; } 
    #else
    public System.String TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on which the trade was executed.
    /// </summary>
    [IsoId("_FQB2cg2JEeSwB74WgTbh4Q")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_KR08YQ2JEeSwB74WgTbh4Q")]
    [DisplayName("Foreign Exchange Trade Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXTradPdct")]
    #endif
    [IsoXmlTag("FXTradPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; } 
    #else
    public UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_FQB2dA2JEeSwB74WgTbh4Q")]
    [DisplayName("Trading Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCcy")]
    #endif
    [IsoXmlTag("TradgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? TradingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TradingCurrency { get; init; } 
    #else
    public string? TradingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement currency of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_FQB2dw2JEeSwB74WgTbh4Q")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of trading method.
    /// </summary>
    [IsoId("_BP7TMEShEeS6cOLECtYLrA")]
    [DisplayName("Trading Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMtd")]
    #endif
    [IsoXmlTag("TradgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingMethodType1Code? TradingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingMethodType1Code? TradingMethod { get; init; } 
    #else
    public TradingMethodType1Code? TradingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_JCGJkEVSEeSGWeX3z5zSZQ")]
    [DisplayName("Trading Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMd")]
    #endif
    [IsoXmlTag("TradgMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingModeType1Code TradingMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingModeType1Code TradingMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingModeType1Code TradingMode { get; init; } 
    #else
    public TradingModeType1Code TradingMode { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing method of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_FQB2dQ2JEeSwB74WgTbh4Q")]
    [DisplayName("Clearing Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMtd")]
    #endif
    [IsoXmlTag("ClrMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClearingMethod1Code ClearingMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClearingMethod1Code ClearingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingMethod1Code ClearingMethod { get; init; } 
    #else
    public ClearingMethod1Code ClearingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Symbol of the trade.
    /// </summary>
    [IsoId("_sixnQIdSEeS8A78Q2OnhsA")]
    [DisplayName("Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Symb")]
    #endif
    [IsoXmlTag("Symb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Symbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Symbol { get; init; } 
    #else
    public System.String? Symbol { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure where the trade confirmation will take place.
    /// </summary>
    [IsoId("_FQB2eA2JEeSwB74WgTbh4Q")]
    [DisplayName("Place Of Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfConf")]
    #endif
    [IsoXmlTag("PlcOfConf")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? PlaceOfConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfConfirmation { get; init; } 
    #else
    public System.String? PlaceOfConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the foreign exchange trade including Spot Forward and NDF.
    /// </summary>
    [IsoId("_FQB2eg2JEeSwB74WgTbh4Q")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Trade3? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trade3? ForeignExchangeDetails { get; init; } 
    #else
    public Trade3? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about each leg of the multileg instrument (foreign exchange swap).
    /// </summary>
    [IsoId("_FQB2ew2JEeSwB74WgTbh4Q")]
    [DisplayName("Swap Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwpLeg")]
    #endif
    [IsoXmlTag("SwpLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstrumentLeg6? SwapLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstrumentLeg6? SwapLeg { get; init; } 
    #else
    public InstrumentLeg6? SwapLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the treasury trade product, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_AbzAYRGEEeSahYR-dAI4lQ")]
    [DisplayName("Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctId")]
    #endif
    [IsoXmlTag("PdctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification22Choice_? ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification22Choice_? ProductIdentification { get; init; } 
    #else
    public SecurityIdentification22Choice_? ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Some associated trade reference needs to be specified.
    /// </summary>
    [IsoId("_BLgREA2JEeSwB74WgTbh4Q")]
    [DisplayName("Associated Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdTradRef")]
    #endif
    [IsoXmlTag("AssoctdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AssociatedTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedTradeReference { get; init; } 
    #else
    public System.String? AssociatedTradeReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
