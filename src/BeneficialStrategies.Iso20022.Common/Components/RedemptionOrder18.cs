// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("be1d7f12-1417-4066-97fe-273a724444dc")]
[DisplayName("Redemption Order18")]
public record RedemptionOrder18
{
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("467e5f72-ca46-46f5-8c73-03c77910d65f")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("24969512-97c8-4df6-a904-65c44dca46a4")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE).
    /// </summary>
    [IsoId("1250d09b-998c-47f0-809a-8bcc344c9a96")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("cec75d05-1654-46e7-831a-0aeb7689fd08")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    [IsoId("fc0b4d63-dc3a-47d0-8785-a9bb1022aaea")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Subdivision of the account used to segregate specific holdings.
    /// </summary>
    [IsoId("91d9dbb3-28de-4c78-8e60-1746e8368984")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount6? SubAccountForHolding { get; init; }

    /// <summary>
    /// Amount of money or the number of units or percentage to be redeemed for the redemption order.
    /// </summary>
    [IsoId("3f2bfe5a-de7f-4c85-8c46-3339cae262b7")]
    [DisplayName("Amount Or Units Or Percentage")]
    [IsoXmlTag("AmtOrUnitsOrPctg")]
    public required FinancialInstrumentQuantity48Choice AmountOrUnitsOrPercentage { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("9ec513fc-ee80-46a5-bb43-4f2cf634e086")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("cb4bd3f9-4890-4103-9826-5e807a58d356")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("a7578a8b-d50b-4777-92a9-df6fa5482fdd")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("89b62895-a052-40bf-8197-725be919424c")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("6ff0e744-e969-469d-b2a4-350eb8661c5b")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms44? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("3091e88d-738e-4949-b33a-bebd425e473c")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong.
    /// </summary>
    [IsoId("19a91548-131e-4d9d-b477-9075f1f68fc7")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    [IsoId("2cc653c9-405e-4131-9cce-bf115ae0b835")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax2? TransactionOverhead { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("287e11e5-0031-4d04-9f26-1c5699a83ad1")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("9a1308bc-18ce-40dd-ab4b-91df2d9d07ef")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("29f3fcfa-eeb6-43d3-a9f4-281256db3fa4")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("2888fef6-dccd-40ef-8246-037ec05ce96b")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund.
    /// </summary>
    [IsoId("ba52d673-f7be-4c57-aee6-62bc76a714ce")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("f4213c0d-3b2d-4dd9-9708-d649e8ad67a3")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction167? CashSettlementDetails { get; init; }

    /// <summary>
    /// Total quantity of digital asset to be paid or received in exchange for the securities token.
    /// </summary>
    [IsoId("480cbd71-869f-4434-9be9-9ec749bc7b78")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("43ea47f1-ffc7-4aa7-b9b8-febc6e53aa06")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("669f8f7f-8bf1-4d41-8caf-8cbc533c2086")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("15b69816-c4b6-482f-bdb8-bf97b4e869d9")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("ed6f34a4-316e-4c41-86c3-48218de5023e")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("f75a4175-9e3c-41a0-b218-9fd1e4a24d3d")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor's retained subscription amount returned by the fund.
    /// </summary>
    [IsoId("0986fa27-cac3-4aff-8ba8-021c46192378")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    /// <summary>
    /// Assessment of the customer's behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("ac5bde4b-b5f2-4f86-8ba0-6b48f2e45550")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("bf25c829-44ae-4f91-b381-a2eff17fb8da")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("9c9ba322-991c-480e-b8e0-d5c4bcb1703b")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("45b98ae9-dcae-4f88-ba24-20185d2a2ab8")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
