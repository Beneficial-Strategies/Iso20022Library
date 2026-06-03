// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor's principal in an investment fund.
/// </summary>
[IsoId("5a4a5eec-77f6-48c6-beab-f7f1d471f03f")]
[DisplayName("Subscription Order17")]
public record SubscriptionOrder17
{
    [IsoId("118faecd-a78c-4b22-9b24-c01a4dc9972d")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    [IsoId("6716a6da-d82c-4dd1-b68c-1d419c9ea078")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    [IsoId("ad2a53d7-5a29-4642-a3f8-8a9ceaa5a746")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    [IsoId("71a2569f-f0ea-4d83-8bf8-aad6c88e7190")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice> OrderType { get; init; } = [];

    [IsoId("c9b93cc6-b60b-4cef-abce-58c1fcbb4049")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    [IsoId("be819546-59f9-4181-bd55-a2cabe68b0e2")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount6? SubAccountForHolding { get; init; }

    [IsoId("e6cd3008-8e4a-4cc6-9449-25bf4bf9ff24")]
    [DisplayName("Amount Or Units")]
    [IsoXmlTag("AmtOrUnits")]
    public required FinancialInstrumentQuantity49Choice AmountOrUnits { get; init; }

    [IsoId("ef45c5e3-efc2-4aa2-aa48-bcd362c92571")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    [IsoId("1d1da64b-cf4d-433d-a7ac-38ead15fb6fe")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    [IsoId("a999f09b-65b3-46d0-9dc4-1b08148b05cc")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    [IsoId("ff48837d-0440-4a5b-9aba-6d58e5af4113")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    [IsoId("c9a6947e-1086-4cd0-bdc4-448f3f92c8ab")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms44? ForeignExchangeDetails { get; init; }

    [IsoId("789ffca9-5639-4c5c-9a71-e89ebf95b9ee")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    [IsoId("7b4da6b7-510f-4733-9d4a-0764b2b93677")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    public IsoMax35Text? LetterIntentReference { get; init; }

    [IsoId("a2e36b6a-7f9f-47e2-8654-7c74bf4925c3")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    [IsoId("af6b6a01-beaa-4918-a53b-dbe02f107710")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax2? TransactionOverhead { get; init; }

    [IsoId("ecd67c02-8ca8-423a-b073-98e6aed01e59")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters22? SettlementAndCustodyDetails { get; init; }

    [IsoId("4e741549-5516-4a0c-9711-c16404e8e448")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    [IsoId("8874c8bf-de82-47ff-a2cd-2814600c941e")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    [IsoId("bf44928b-1153-4293-b47b-f685608f3536")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    [IsoId("28a6c100-922d-4dc9-a7a0-32d17f933623")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    [IsoId("ddce01bb-b7ff-4d5f-9f13-093be36ea02f")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction180? CashSettlementDetails { get; init; }

    [IsoId("68b8a20c-fc50-4351-8cff-8aad9fce1b49")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    [IsoId("7191624f-e908-4824-b5db-426eabb3706b")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("9665d886-caf0-4711-ad51-659bce87539c")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    [IsoId("a288adbd-f021-48a2-b394-6df4f12f6b21")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    [IsoId("dd54a507-d7de-44f5-a49c-e4d77e4be635")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    [IsoId("f0d6579c-6e91-4183-837a-e024419ee728")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary50> RelatedPartyDetails { get; init; } = [];

    [IsoId("16a5d866-675d-4727-995a-a3b9c7f8e3ca")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    [IsoId("fa275d26-9c79-45e0-8604-be42f408ff6b")]
    [DisplayName("Source Of Cash")]
    [IsoXmlTag("SrcOfCsh")]
    public ValueList<SourceOfCash1Choice> SourceOfCash { get; init; } = [];

    [IsoId("1c22c54d-c676-4fab-a2cd-9db253e43dc8")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice? CustomerConductClassification { get; init; }

    [IsoId("14dae140-42c6-4b96-be6d-efed8051f0cb")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice? TransactionChannelType { get; init; }

    [IsoId("1c9858dc-3a96-4f71-96ca-8fa427c46cac")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice? SignatureType { get; init; }

    [IsoId("fb797c7b-6511-4f6c-8d58-95e9bc72bf03")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
