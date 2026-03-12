// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the treasury trade captured.
/// </summary>
[IsoId("_sJMGoAKMEeStmNeY_LieLw")]
[DisplayName("Trade")]
public partial record Trade1
{
    #nullable enable
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_FtqxAAKOEeStmNeY_LieLw")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the trade was executed.
    /// </summary>
    [IsoId("_qpf9AJ-yEeS9JvCuR85TWA")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateAndTime { get; init; } 
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_eGCUUQ8WEeSFHsNYty4C9Q")]
    [DisplayName("Foreign Exchange Trade Product")]
    [IsoXmlTag("FXTradPdct")]
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; init; } 
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_xfWdkAKNEeStmNeY_LieLw")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; } 
    
    /// <summary>
    /// Settlement currency of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_Ktg0wAvGEeSMj_LPtVIELA")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public CurrencyCode? SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the type of trading method.
    /// </summary>
    [IsoId("_BUyh4ESdEeS6cOLECtYLrA")]
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public required TradingMethodType1Code TradingMethod { get; init; } 
    
    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_5jz2oEVREeSGWeX3z5zSZQ")]
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public TradingModeType1Code? TradingMode { get; init; } 
    
    /// <summary>
    /// Clearing method of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_UCh9wAKOEeStmNeY_LieLw")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod1Code ClearingMethod { get; init; } 
    
    /// <summary>
    /// Identifies current status of the trade.
    /// </summary>
    [IsoId("_ukQGsIv7EeSJHZdigg3NTg")]
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public required OrderStatus8Code ExecutionType { get; init; } 
    
    /// <summary>
    /// Symbol of the trade.
    /// </summary>
    [IsoId("_5wKMMIceEeSSpbtwQkzChA")]
    [DisplayName("Symbol")]
    [IsoXmlTag("Symb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Symbol { get; init; } 
    
    /// <summary>
    /// Infrastructure where the trade confirmation will take place.
    /// </summary>
    [IsoId("_8VvYUAKNEeStmNeY_LieLw")]
    [DisplayName("Place Of Confirmation")]
    [IsoXmlTag("PlcOfConf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlaceOfConfirmation { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was executed.
    /// </summary>
    [IsoId("_F5UgwIvdEeSJHZdigg3NTg")]
    [DisplayName("Transaction Time")]
    [IsoXmlTag("TxTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionTime { get; init; } 
    
    /// <summary>
    /// Provides details of the foreign exchange trade including Spot Forward and NDF.
    /// </summary>
    [IsoId("_RJwWIA2MEeSw7Op2IIeBeQ")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public Trade3? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Provides details about each leg of the multileg instrument (foreign exchange swap).
    /// </summary>
    [IsoId("_ybY9oQ2GEeSw7Op2IIeBeQ")]
    [DisplayName("Swap Leg")]
    [IsoXmlTag("SwpLeg")]
    public InstrumentLeg6? SwapLeg { get; init; } 
    
    /// <summary>
    /// Specifies the parameters of the foreign exchange option.
    /// </summary>
    [IsoId("_zbUJkQ2GEeSw7Op2IIeBeQ")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public Option10? Option { get; init; } 
    
    /// <summary>
    /// Identification of the treasury trade product, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_ctXI0w8kEeSFHsNYty4C9Q")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification22Choice_? ProductIdentification { get; init; } 
    
    
    #nullable disable
    
}
