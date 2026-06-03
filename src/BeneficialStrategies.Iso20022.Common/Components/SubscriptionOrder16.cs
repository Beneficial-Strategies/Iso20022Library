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
[IsoId("028d69a3-118c-47b4-b43c-480b910992ef")]
[DisplayName("Subscription Order16")]
public record SubscriptionOrder16
{
    [IsoId("4e9d6841-3b49-41d8-b859-6648e0022e7c")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    [IsoId("ed729fd2-f4f2-41c2-8f84-80698535b581")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    [IsoId("472ca133-ab53-46fe-b4ea-0b6627e50871")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    [IsoId("e56b02e4-f6ce-49da-9a7e-1823bc59c6a0")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];

    [IsoId("e8bd13f0-f86b-4b7e-8913-0eba2f3efc82")]
    [DisplayName("Amount Or Units")]
    [IsoXmlTag("AmtOrUnits")]
    public required FinancialInstrumentQuantity49Choice_ AmountOrUnits { get; init; }

    [IsoId("b6710d74-fdac-4f64-9794-8d9af8ce7ae9")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    [IsoId("75275d14-9f9f-4b80-abd0-ae9c51509f79")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    [IsoId("359cfa46-7f89-451b-87bf-c39ccb8d9e5a")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    [IsoId("5a145105-1dd4-4391-8a23-5a60f92eb3ae")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    [IsoId("1c395ca8-7c88-43a1-b3b7-f3dea7655714")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    [IsoId("c993a0a2-2e9b-4ee5-8dbe-65bd7ba993d3")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    [IsoId("eed05bcc-8b33-4575-8577-28866cf1a57d")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson31> BeneficiaryDetails { get; init; } = [];

    [IsoId("52b78dec-c238-4565-8158-2d15c8ee850a")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms44? ForeignExchangeDetails { get; init; }

    [IsoId("58a90df0-74dd-481d-94c7-f2787bbd0322")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    public IsoMax35Text? LetterIntentReference { get; init; }

    [IsoId("c68342bd-7c8b-45b2-8fef-739916f18c60")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    [IsoId("1f82627f-676d-4ca0-af8f-655a282b12e1")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public FeeAndTax2? TransactionOverhead { get; init; }

    [IsoId("1e11a199-868f-4e25-ba82-c8a875edae91")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters22? SettlementAndCustodyDetails { get; init; }

    [IsoId("ea6a8373-aab8-4b3f-a8f9-b68bd096d63d")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    [IsoId("b101a978-e37b-4c3a-b526-8132c9e58e1a")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    [IsoId("e0592199-e9ed-42a9-a4a2-91eb10b46349")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction180? CashSettlementDetails { get; init; }

    [IsoId("eba87e10-7b84-4c84-a410-dd1724cac04e")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    [IsoId("a83d6441-5a08-41ac-b39b-c385079004dc")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("fdf4064c-7301-42ac-af15-3e6c915d9904")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    [IsoId("0e67beef-365c-492c-a4f9-eb1317b1d0e0")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    [IsoId("b508e658-8bcd-40d8-81a2-bba8997b362b")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    [IsoId("fb37efcd-70a6-40b7-b47a-0908d357b9e1")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    [IsoId("ff5c8f28-8c4c-471f-bede-281426fd1ce5")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    [IsoId("24f4b615-eea7-411f-b540-1dab117f0d7f")]
    [DisplayName("Source Of Cash")]
    [IsoXmlTag("SrcOfCsh")]
    public ValueList<SourceOfCash1Choice_> SourceOfCash { get; init; } = [];

    [IsoId("6986f3bb-ab4f-4eb9-91cb-37024c532513")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    [IsoId("f806f0d8-2981-41ca-b381-5a20f23c7fb7")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    [IsoId("c958b839-4f9b-4494-8e0c-7347c0f2a4ae")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    [IsoId("342ba918-eb10-4fa6-b41a-bbcaa3975bcc")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
