// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("398ebf77-74c4-4965-8d41-84270a5ab8c0")]
[DisplayName("Redemption Execution18")]
public record RedemptionExecution18
{
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("15ae7da7-6a1f-484f-8d89-1c98d8ded308")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("b85ec111-2b5e-4942-9903-0280fcc10dc9")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("f3e054ed-4eb9-47a6-b498-3c998b09c3d6")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE).
    /// </summary>
    [IsoId("f0e87e01-5d87-49a0-86de-2a21142df974")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("41f71ea4-8b0e-4104-9373-59862913d05c")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice> OrderType { get; init; } = [];

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("f94a58c1-49c1-4ea0-bb04-4f7fb2d1cc85")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Quantity of units or digital tokens.
    /// </summary>
    [IsoId("2eb0f24c-d909-434b-9982-2b9a634803e8")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice Units { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("127a072b-18cc-4d17-8fa9-2cc06f901ed9")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money paid to the investor when redeeming fund units.
    /// </summary>
    [IsoId("9ff8b98a-8e63-491d-8bba-611b9d5118c1")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("8979e3d5-7e08-42d5-8416-a915a3685b66")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Portion of the investor's holdings redeemed.
    /// </summary>
    [IsoId("eaa27568-97c8-421d-8076-4bb607b396c7")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Amount of money redeemed from the fund.
    /// </summary>
    [IsoId("7b2ad050-0b0e-41bb-96ec-92bf1d48191a")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("b73aa1b6-8d14-46cd-9189-d9cbb0f7c984")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice TradeDateTime { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("b51484ef-c90e-4c21-9a60-16c3c1a0ffce")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("136cc58e-c4d0-407f-9af7-2ab39045510e")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("fbdabc4d-f78f-4a0a-9ae2-b123357078c7")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("c0b5761c-94bb-46bd-b956-d8890df7b4a3")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("bf9d0860-d689-4c07-943b-9521ee6e94e6")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the order has been partially executed.
    /// </summary>
    [IsoId("1183b07b-f4da-46e7-a2a8-4c60a407a3f3")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("58219029-39bf-47d1-8a88-9f41c1b1017f")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included in the executed price.
    /// </summary>
    [IsoId("c030efff-0421-4200-8a46-e2af207dc936")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital.
    /// </summary>
    [IsoId("2f761ef7-efa0-4634-860b-745c0e9dabe1")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("cbe77d70-a096-462c-bd32-1f5308e4db4b")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("993f3e7b-dff7-4a2a-bc1a-b8cf1ccb2f65")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong.
    /// </summary>
    [IsoId("3c10168f-cf86-445f-ae29-6bd1de958f84")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction.
    /// </summary>
    [IsoId("a08ad377-a33c-4594-a553-3c316329d3a0")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes45? TransactionOverhead { get; init; }

    /// <summary>
    /// Additional information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    [IsoId("372fab5c-b45b-4e61-ab7f-212255255060")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("7e02ce0a-9824-4bf0-96fe-11a07fe7aff6")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("e48e7948-8ef3-47aa-826f-fa7bb4c3af3f")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters22? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("aac6ddee-e202-4e9e-b2dc-812276f04a36")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("8ceefcba-bda8-4df2-bfd5-9892c376024f")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("2952703b-5336-4cf2-9ade-8300f70d07bc")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction167? CashSettlementDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("8ea1f2b2-f211-4a34-93a9-f6ad1c1fada5")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("d360388b-bf36-4570-ad76-58131ed02e83")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("d3dd2716-b7f0-4514-a616-e473503d32ba")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("07088da8-f51e-46d6-84d4-03ef7833db86")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Amount retained by the fund and paid out later at a time decided by the fund.
    /// </summary>
    [IsoId("9cd1684c-f74a-4ff5-9aee-784bec2d80be")]
    [DisplayName("Partial Redemption Withholding Amount")]
    [IsoXmlTag("PrtlRedWhldgAmt")]
    public ActiveCurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; }

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("d6116d34-0bef-46f9-bfad-b4cee6e6baea")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("1b12eb22-4de6-4454-97d5-0358a4d23c1f")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("a2fd2b2c-ad46-442e-a0f2-fd8a3809ea37")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("367c2b5b-0f5d-47ca-9dff-de76076a46a5")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor's subscription amount held by the fund and returned due to the redemption.
    /// </summary>
    [IsoId("e117c233-aa46-4874-8e07-c357d11c844e")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    /// <summary>
    /// Assessment of the customer's behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("e7ca5961-d3e7-4dee-b3e8-9767f4643573")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("c0aa0c08-77e3-4328-808a-8805f65197fc")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("2a4ff0cf-ef4d-4a85-b0d8-43093dc13ac0")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("d3cd331a-83a9-428d-b4b4-4ede3056a35f")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }

    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    [IsoId("7f407cf8-7a30-469f-9f9f-5c0b0cbc0a32")]
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation5? GatingOrHoldBackDetails { get; init; }
}
