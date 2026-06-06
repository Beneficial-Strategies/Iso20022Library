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
[IsoId("0a13380a-6616-49a0-9182-705b363b5e79")]
[DisplayName("Subscription Execution15")]
public record SubscriptionExecution15
{
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("ef9fa822-b86a-47f7-b813-b52471f396df")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("4fb0eac9-7dc7-483e-990c-8ed2c9cbb59c")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("3cf0632b-5157-4a37-8550-7465511b5466")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("6fda6ed4-5cdf-4dcb-aefb-7d538c632603")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("bfe84050-c372-44ae-82b3-5052ff8e64d0")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("ea1627e3-c408-4d56-9369-d379f4e787cc")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("33ecbb19-78eb-4139-b58c-c999598e6522")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson31> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Quantity of units or digital tokens.
    /// </summary>
    [IsoId("0f5627e2-5f0c-4bd1-9a8f-7eb9b539aeff")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("88c00919-d74a-46f6-8396-8304ef443674")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money invested in the fund. |Net Amount = Quantity * Price.
    /// </summary>
    [IsoId("0a09ad28-e4f0-4d54-ba7a-9cc916c9c362")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money to be paid by the investor when subscribing to fund units.|Gross amount = (Quantity * Price) + (Fees + Taxes).
    /// </summary>
    [IsoId("d5c9c37e-baf9-487a-ba92-acbfd3ca17ed")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("5cefe8eb-7fc3-4b17-9df6-35d348e2df49")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("2e684c5e-7c03-453f-a8f7-f62f449136f0")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("b41ef508-4ff8-4cde-b82a-9e8309af3219")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("bee7fe9f-a4c0-45c9-b707-c8823eea0c7d")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("2470d032-0320-4601-8e7f-75c1c83d7e7c")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("eb6c8a23-f129-4dce-b154-cae9cb58d16c")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("877df7c0-d7b4-4320-9d89-b58e9bf9defb")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("bdbd1eb5-47e2-4635-a24e-9c924bc7c80c")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("94bbff21-b801-41d1-ab4d-7888686b2954")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("6362071d-438b-4920-83a7-abd7936d0c3e")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.|How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:|EXAMPLE 1 |UnitCurrency EUR|QuotedCurrency USD|ExchangeRate 1.300|EXAMPLE 2|UnitCurrency USD|QuotedCurrency EUR|ExchangeRate 0.769.
    /// </summary>
    [IsoId("eb5e739b-8343-4811-86c7-3a756a109c1e")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("a874ca78-0916-48b3-abfc-a936908772a4")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("84f02554-da5b-43d1-aacd-dd6d32dc8aa7")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("abe8d1e5-c09a-4245-a87c-b394d37be3bb")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction, so that the total difference between the net amount and gross amount is known, without taking into account equalisation.
    /// </summary>
    [IsoId("74d01766-c65e-4e00-8c33-b16777091344")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes45? TransactionOverhead { get; init; }

    /// <summary>
    /// Additional information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    [IsoId("56c1a4e1-fe82-4c59-bdc9-0800e49c5ac8")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("4343ddd6-4fbb-434c-909b-50277118b888")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("5ad24151-cf11-4c1d-8467-c6e5527e07ac")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("f34dfd61-113d-4af5-abd2-bb6535a22858")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("6aa2874f-8524-47e5-8ade-8626c35bb776")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("89781df9-d4cb-482a-a431-1511d00a13ae")]
    [DisplayName("Refund")]
    [IsoXmlTag("Rfnd")]
    public ActiveCurrencyAndAmount? Refund { get; init; }

    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    [IsoId("8c16982f-c5dc-4861-af5b-f6e24369f792")]
    [DisplayName("Subscription Interest")]
    [IsoXmlTag("SbcptIntrst")]
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("5f941717-cd34-4d40-8015-d2ecc6e16ff7")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction180? CashSettlementDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("3c655bf6-6d71-490a-a331-95cec245ce50")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("adff3713-f79b-499d-ace3-03b51670d0ce")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("1bc322f5-3689-4bb2-92b0-e4fd5140dd47")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("74f8bde1-e282-420f-87c3-219a0f7a63ff")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("f8159e9e-7cd6-4c8c-b487-a986098fde5d")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("52c5a6dd-089a-48f9-9221-a1f61aca8d85")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("a9c5debe-8a3a-4afb-bf28-28dd5901d6f9")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("cddc4dd3-b1d3-42c2-9798-bb7a65b8c8f0")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("1603321d-d1d8-4712-bfb9-c58805abb65d")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    /// <summary>
    /// Source of cash used for the settlement of the subscription.
    /// </summary>
    [IsoId("aab5e83f-90d2-497e-90a8-66ee38e0fe56")]
    [DisplayName("Source Of Cash")]
    [IsoXmlTag("SrcOfCsh")]
    public ValueList<SourceOfCash1Choice_> SourceOfCash { get; init; } = [];

    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("1447ff65-d835-440c-8183-87e69e54853a")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("88f634be-05c3-40b2-88cc-48eb89e80924")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("e6e96ade-4e9b-4161-bd09-b389e7a5fe4f")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("16732378-05c6-48df-a0ca-fb45cc98a964")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
