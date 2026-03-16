// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade7.
/// </summary>
[IsoId("_jx9zYYLoEe24QcyNUDsP1A")]
[DisplayName("Trade7")]
public partial record Trade7
{
    #nullable enable

    /// <summary>
    /// Base Currency Or Amount.
    /// </summary>
    [DisplayName("Base Currency Or Amount")]
    [IsoXmlTag("BaseCcyOrAmt")]
    public AmountAndCurrency2? BaseCurrencyOrAmount { get; init; } 

    /// <summary>
    /// Clearing Method.
    /// </summary>
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod1Code ClearingMethod { get; init; } 

    /// <summary>
    /// Combination Deal Ticket Identification.
    /// </summary>
    [DisplayName("Combination Deal Ticket Identification")]
    [IsoXmlTag("CmbntnDealTcktId")]
    public IsoMax35Text? CombinationDealTicketIdentification { get; init; } 

    /// <summary>
    /// Contra Currency.
    /// </summary>
    [DisplayName("Contra Currency")]
    [IsoXmlTag("ContraCcy")]
    public ActiveCurrencyCode? ContraCurrency { get; init; } 

    /// <summary>
    /// Date And Time.
    /// </summary>
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required IsoISODateTime DateAndTime { get; init; } 

    /// <summary>
    /// Date Confirmed.
    /// </summary>
    [DisplayName("Date Confirmed")]
    [IsoXmlTag("DtConfd")]
    public IsoISODate? DateConfirmed { get; init; } 

    /// <summary>
    /// Deal Ticket Identification.
    /// </summary>
    [DisplayName("Deal Ticket Identification")]
    [IsoXmlTag("DealTcktId")]
    public IsoMax30Text? DealTicketIdentification { get; init; } 

    /// <summary>
    /// Execution Type.
    /// </summary>
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public required OrderStatus8Code ExecutionType { get; init; } 

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public Trade10? ForeignExchangeDetails { get; init; } 

    /// <summary>
    /// Foreign Exchange Trade Product.
    /// </summary>
    [DisplayName("Foreign Exchange Trade Product")]
    [IsoXmlTag("FXTradPdct")]
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; init; } 

    /// <summary>
    /// Option.
    /// </summary>
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public Option16? Option { get; init; } 

    /// <summary>
    /// Place Of Confirmation.
    /// </summary>
    [DisplayName("Place Of Confirmation")]
    [IsoXmlTag("PlcOfConf")]
    public IsoMax35Text? PlaceOfConfirmation { get; init; } 

    /// <summary>
    /// Product Identification.
    /// </summary>
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification38Choice_? ProductIdentification { get; init; } 

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 

    /// <summary>
    /// Swap Leg.
    /// </summary>
    [DisplayName("Swap Leg")]
    [IsoXmlTag("SwpLeg")]
    public ValueList<InstrumentLeg7> SwapLeg { get; init; } = [];

    /// <summary>
    /// Symbol.
    /// </summary>
    [DisplayName("Symbol")]
    [IsoXmlTag("Symb")]
    public required IsoMax35Text Symbol { get; init; } 

    /// <summary>
    /// Target Currency Or Amount.
    /// </summary>
    [DisplayName("Target Currency Or Amount")]
    [IsoXmlTag("TrgtCcyOrAmt")]
    public AmountAndCurrency2? TargetCurrencyOrAmount { get; init; } 

    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public required IsoMax35Text TradeIdentification { get; init; } 

    /// <summary>
    /// Trading Currency.
    /// </summary>
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public ActiveCurrencyCode? TradingCurrency { get; init; } 

    /// <summary>
    /// Trading Method.
    /// </summary>
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public required TradingMethodType1Code TradingMethod { get; init; } 

    /// <summary>
    /// Trading Mode.
    /// </summary>
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public TradingModeType1Code? TradingMode { get; init; } 

    /// <summary>
    /// Transaction Time.
    /// </summary>
    [DisplayName("Transaction Time")]
    [IsoXmlTag("TxTm")]
    public IsoISODateTime? TransactionTime { get; init; } 

    
    #nullable disable
    
}
