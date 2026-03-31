// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[IsoId("_QxmtEStJEeOgfbujmhmNAA")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails35
{
    /// <summary>
    /// Identification of an account owner transaction that could potentially match with the allegement notified.
    /// </summary>
    [IsoId("_RKmb9ytJEeOgfbujmhmNAA")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_RKmb_ytJEeOgfbujmhmNAA")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_RKmcBytJEeOgfbujmhmNAA")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    [IsoId("_RKmcDytJEeOgfbujmhmNAA")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_RKmcEStJEeOgfbujmhmNAA")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_RKmcGStJEeOgfbujmhmNAA")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_RKmcIStJEeOgfbujmhmNAA")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("_RKmcKStJEeOgfbujmhmNAA")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_RKmcMStJEeOgfbujmhmNAA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_RKmcOStJEeOgfbujmhmNAA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Status of the allegement.
    /// </summary>
    [IsoId("_RKmcQStJEeOgfbujmhmNAA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AllegementStatus1Choice_? Status { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_RKmcSStJEeOgfbujmhmNAA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification78? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_RKmcUStJEeOgfbujmhmNAA")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_RKmcWStJEeOgfbujmhmNAA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_RKmcYStJEeOgfbujmhmNAA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate1Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_RKmcaStJEeOgfbujmhmNAA")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price2? DealPrice { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_RKmccStJEeOgfbujmhmNAA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_RKmceStJEeOgfbujmhmNAA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_RKmcgStJEeOgfbujmhmNAA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_RKmciStJEeOgfbujmhmNAA")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition1Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_RKmckStJEeOgfbujmhmNAA")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Details about the financial instrument quantity and the account involved in the transaction.
    /// </summary>
    [IsoId("_RKmcmStJEeOgfbujmhmNAA")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount26 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_RKmcoStJEeOgfbujmhmNAA")]
    [DisplayName("Securities Financing Details")]
    [IsoXmlTag("SctiesFincgDtls")]
    public SecuritiesFinancingTransactionDetails7? SecuritiesFinancingDetails { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_RKmcqStJEeOgfbujmhmNAA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails49 SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_RKmcsStJEeOgfbujmhmNAA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties11? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_RKmcuStJEeOgfbujmhmNAA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties11? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_RKmcwStJEeOgfbujmhmNAA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection22? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_RKmcyStJEeOgfbujmhmNAA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts8? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_RKmc0StJEeOgfbujmhmNAA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties11? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RKmc2StJEeOgfbujmhmNAA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
