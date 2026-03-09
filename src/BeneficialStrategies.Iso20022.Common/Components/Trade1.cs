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
/// Details of the treasury trade captured.
/// </summary>
[IsoId("_sJMGoAKMEeStmNeY_LieLw")]
[DisplayName("Trade")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Trade1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Trade1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Trade1( System.String reqTradeIdentification,System.DateTime reqDateAndTime,TradingMethodType1Code reqTradingMethod,ClearingMethod1Code reqClearingMethod,OrderStatus8Code reqExecutionType,System.String reqSymbol )
    {
        TradeIdentification = reqTradeIdentification;
        DateAndTime = reqDateAndTime;
        TradingMethod = reqTradingMethod;
        ClearingMethod = reqClearingMethod;
        ExecutionType = reqExecutionType;
        Symbol = reqSymbol;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_FtqxAAKOEeStmNeY_LieLw")]
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
    /// Date and time at which the trade was executed.
    /// </summary>
    [IsoId("_qpf9AJ-yEeS9JvCuR85TWA")]
    [DisplayName("Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTm")]
    #endif
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DateAndTime { get; init; } 
    #else
    public System.DateTime DateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_eGCUUQ8WEeSFHsNYty4C9Q")]
    [DisplayName("Foreign Exchange Trade Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXTradPdct")]
    #endif
    [IsoXmlTag("FXTradPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; init; } 
    #else
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_xfWdkAKNEeStmNeY_LieLw")]
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
    [IsoId("_Ktg0wAvGEeSMj_LPtVIELA")]
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
    [IsoId("_BUyh4ESdEeS6cOLECtYLrA")]
    [DisplayName("Trading Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMtd")]
    #endif
    [IsoXmlTag("TradgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingMethodType1Code TradingMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingMethodType1Code TradingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingMethodType1Code TradingMethod { get; init; } 
    #else
    public TradingMethodType1Code TradingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_5jz2oEVREeSGWeX3z5zSZQ")]
    [DisplayName("Trading Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMd")]
    #endif
    [IsoXmlTag("TradgMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingModeType1Code? TradingMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingModeType1Code? TradingMode { get; init; } 
    #else
    public TradingModeType1Code? TradingMode { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing method of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_UCh9wAKOEeStmNeY_LieLw")]
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
    /// Identifies current status of the trade.
    /// </summary>
    [IsoId("_ukQGsIv7EeSJHZdigg3NTg")]
    [DisplayName("Execution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTp")]
    #endif
    [IsoXmlTag("ExctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus8Code ExecutionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus8Code ExecutionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus8Code ExecutionType { get; init; } 
    #else
    public OrderStatus8Code ExecutionType { get; set; } 
    #endif
    
    /// <summary>
    /// Symbol of the trade.
    /// </summary>
    [IsoId("_5wKMMIceEeSSpbtwQkzChA")]
    [DisplayName("Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Symb")]
    #endif
    [IsoXmlTag("Symb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Symbol { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Symbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Symbol { get; init; } 
    #else
    public System.String Symbol { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure where the trade confirmation will take place.
    /// </summary>
    [IsoId("_8VvYUAKNEeStmNeY_LieLw")]
    [DisplayName("Place Of Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfConf")]
    #endif
    [IsoXmlTag("PlcOfConf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlaceOfConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfConfirmation { get; init; } 
    #else
    public System.String? PlaceOfConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was executed.
    /// </summary>
    [IsoId("_F5UgwIvdEeSJHZdigg3NTg")]
    [DisplayName("Transaction Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTm")]
    #endif
    [IsoXmlTag("TxTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionTime { get; init; } 
    #else
    public System.DateTime? TransactionTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the foreign exchange trade including Spot Forward and NDF.
    /// </summary>
    [IsoId("_RJwWIA2MEeSw7Op2IIeBeQ")]
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
    [IsoId("_ybY9oQ2GEeSw7Op2IIeBeQ")]
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
    /// Specifies the parameters of the foreign exchange option.
    /// </summary>
    [IsoId("_zbUJkQ2GEeSw7Op2IIeBeQ")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Option10? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Option10? Option { get; init; } 
    #else
    public Option10? Option { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the treasury trade product, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_ctXI0w8kEeSFHsNYty4C9Q")]
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
    
    
    #nullable disable
    
}
