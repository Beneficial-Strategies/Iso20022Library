// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("d64a88ea-0c08-4f10-b789-44790e74e4bd")]
[DisplayName("Subscription Execution16")]
public record SubscriptionExecution16
{
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("9c0dc3f8-7010-4a8a-b716-b5abbc8bd890")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("e6e2fed0-8a36-4208-b50b-7eae35724136")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("2c7eb768-f40d-415e-b290-fcc11897d4d5")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("5800f906-f094-4517-8894-acfa0dc5239e")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("f7b1295a-1a02-4a9d-af2d-4a8c7442637e")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class to which the investment fund order execution is related.
    /// </summary>
    [IsoId("79df7b22-175b-4033-b75a-897ecac7fc17")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Subdivision of the account used to segregate specific holdings.
    /// </summary>
    [IsoId("91d3f5ca-61df-4979-b0ab-2dfa9ac5efa7")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount6? SubAccountForHolding { get; init; }

    /// <summary>
    /// Quantity of units or digital tokens.
    /// </summary>
    [IsoId("9668365c-61df-4567-8f41-519f70c8cd9c")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("251480bd-260a-4913-afed-30d87d10aaf2")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money invested in the fund. |Net Amount = Quantity * Price.
    /// </summary>
    [IsoId("fe1bc748-c985-4497-98a0-5d73910d407f")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money to be paid by the investor when subscribing to fund units.|Gross amount = (Quantity * Price) + (Fees + Taxes).
    /// </summary>
    [IsoId("9c38b9af-d3f8-4086-b3fa-62da68e79d99")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("736a04a1-5144-4a47-89f3-65db156d9362")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("110c053a-9cd8-442c-a28d-a2ad62b5d870")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("188c6f94-8052-4491-a3a7-30199621d120")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("be04a510-ddc3-4c32-a5ca-52419edf6a02")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("5a3efcfd-5078-4726-b7d7-9b6cd45d09c6")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("8b772836-6151-4c8f-98b3-ccc33080781f")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("31294d06-5e95-42cb-9629-7c8efaf2da38")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("97ef8116-0b08-4f84-bb44-96083571a8e0")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("cc18c4b3-01b7-476e-b932-d24c0aa62f65")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("9cdde805-334b-4453-b904-feb629559f3f")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.|How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:|EXAMPLE 1 |UnitCurrency EUR|QuotedCurrency USD|ExchangeRate 1.300|EXAMPLE 2|UnitCurrency USD|QuotedCurrency EUR|ExchangeRate 0.769.
    /// </summary>
    [IsoId("d8f40d87-135a-4b3f-89f8-052dc2fbc43d")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("3c32e9c1-2667-407c-a619-2fe55de67bc8")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("c1f89252-a275-4806-a790-e7c652b001e2")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("02eea6dc-24fb-4946-b44e-8c3c7500d319")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction, so that the total difference between the net amount and gross amount is known, without taking into account equalisation.
    /// </summary>
    [IsoId("5f3cd200-6319-4c65-a6e0-bfe99ac9078a")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes45? TransactionOverhead { get; init; }

    /// <summary>
    /// Information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    [IsoId("35d7220d-1332-40de-bf27-7a8a07c2cbc6")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("e1468a3b-3950-49ab-96c6-3e88f3ff673a")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("849a8d70-c034-4f77-bb5a-3a50fe4d7f26")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("3e5c2bc6-3255-49f4-9892-bdcceeb89c74")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("224048a2-ab53-4235-86ce-295dcae34b47")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("f493da36-2b08-4686-99a8-bc695de68301")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("83f9c938-0df5-4a30-bc3e-b962e54d596b")]
    [DisplayName("Refund")]
    [IsoXmlTag("Rfnd")]
    public ActiveCurrencyAndAmount? Refund { get; init; }

    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    [IsoId("edf146d3-d0fc-42c8-aaeb-1827617b9809")]
    [DisplayName("Subscription Interest")]
    [IsoXmlTag("SbcptIntrst")]
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("4371d2b8-8845-4fac-bfe9-43e0d5444e85")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction180? CashSettlementDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("094d2373-0f5c-4679-8f62-a433240f43f0")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("8eb1dfae-b71c-4050-a1a0-c134ed2d0d1d")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("216a4400-3b5b-4ea1-a187-084c0783b155")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("4acfcd55-b9d7-4691-ab0a-9a26d2102556")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("98934f43-ace2-4f51-8963-d55fac655d48")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("81cb916f-b2d2-4e12-8fad-8ed217819819")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("ab016635-9710-461d-bac9-661c1b66d880")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("ef94a59d-709e-4c30-8246-1bea42186a7a")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("604b4c29-de6c-48e1-9c65-9aee83a9efa2")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive/performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("c3fc65eb-1eaa-40b4-a8f7-866218652cad")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation4? Equalisation { get; init; }

    /// <summary>
    /// Source of cash used for the settlement of the subscription.
    /// </summary>
    [IsoId("456be021-f552-4930-baf1-390087703005")]
    [DisplayName("Source Of Cash")]
    [IsoXmlTag("SrcOfCsh")]
    public ValueList<SourceOfCash1Choice_> SourceOfCash { get; init; } = [];

    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("8e9988f7-536b-47f2-9945-77d4137b9693")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("24da9ac3-9781-436a-b051-878a4f7c65ac")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("20f787ef-0800-4b6d-bb14-97d1a12b2a05")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("22eebe4c-8541-4c96-a23d-b1b272892def")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
