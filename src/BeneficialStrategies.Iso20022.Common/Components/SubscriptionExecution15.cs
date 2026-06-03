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
    [IsoId("ef9fa822-b86a-47f7-b813-b52471f396df")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    [IsoId("4fb0eac9-7dc7-483e-990c-8ed2c9cbb59c")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    [IsoId("3cf0632b-5157-4a37-8550-7465511b5466")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    [IsoId("6fda6ed4-5cdf-4dcb-aefb-7d538c632603")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    [IsoId("bfe84050-c372-44ae-82b3-5052ff8e64d0")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];

    [IsoId("ea1627e3-c408-4d56-9369-d379f4e787cc")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    [IsoId("33ecbb19-78eb-4139-b58c-c999598e6522")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson31> BeneficiaryDetails { get; init; } = [];

    [IsoId("0f5627e2-5f0c-4bd1-9a8f-7eb9b539aeff")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    [IsoId("88c00919-d74a-46f6-8396-8304ef443674")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    [IsoId("0a09ad28-e4f0-4d54-ba7a-9cc916c9c362")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    [IsoId("d5c9c37e-baf9-487a-ba92-acbfd3ca17ed")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    [IsoId("5cefe8eb-7fc3-4b17-9df6-35d348e2df49")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice_ TradeDateTime { get; init; }

    [IsoId("2e684c5e-7c03-453f-a8f7-f62f449136f0")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; }

    [IsoId("b41ef508-4ff8-4cde-b82a-9e8309af3219")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    [IsoId("bee7fe9f-a4c0-45c9-b707-c8823eea0c7d")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    [IsoId("2470d032-0320-4601-8e7f-75c1c83d7e7c")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    [IsoId("eb6c8a23-f129-4dce-b154-cae9cb58d16c")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    [IsoId("877df7c0-d7b4-4320-9d89-b58e9bf9defb")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    [IsoId("bdbd1eb5-47e2-4635-a24e-9c924bc7c80c")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    [IsoId("94bbff21-b801-41d1-ab4d-7888686b2954")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    [IsoId("6362071d-438b-4920-83a7-abd7936d0c3e")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; }

    [IsoId("eb5e739b-8343-4811-86c7-3a756a109c1e")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    [IsoId("a874ca78-0916-48b3-abfc-a936908772a4")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    [IsoId("84f02554-da5b-43d1-aacd-dd6d32dc8aa7")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    public IsoMax35Text? LetterIntentReference { get; init; }

    [IsoId("abe8d1e5-c09a-4245-a87c-b394d37be3bb")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    [IsoId("74d01766-c65e-4e00-8c33-b16777091344")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes45? TransactionOverhead { get; init; }

    [IsoId("56c1a4e1-fe82-4c59-bdc9-0800e49c5ac8")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    [IsoId("4343ddd6-4fbb-434c-909b-50277118b888")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    [IsoId("5ad24151-cf11-4c1d-8467-c6e5527e07ac")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    [IsoId("f34dfd61-113d-4af5-abd2-bb6535a22858")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    [IsoId("6aa2874f-8524-47e5-8ade-8626c35bb776")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];

    [IsoId("89781df9-d4cb-482a-a431-1511d00a13ae")]
    [DisplayName("Refund")]
    [IsoXmlTag("Rfnd")]
    public ActiveCurrencyAndAmount? Refund { get; init; }

    [IsoId("8c16982f-c5dc-4861-af5b-f6e24369f792")]
    [DisplayName("Subscription Interest")]
    [IsoXmlTag("SbcptIntrst")]
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; }

    [IsoId("5f941717-cd34-4d40-8015-d2ecc6e16ff7")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction180? CashSettlementDetails { get; init; }

    [IsoId("3c655bf6-6d71-490a-a331-95cec245ce50")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    [IsoId("adff3713-f79b-499d-ace3-03b51670d0ce")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("1bc322f5-3689-4bb2-92b0-e4fd5140dd47")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    [IsoId("74f8bde1-e282-420f-87c3-219a0f7a63ff")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    [IsoId("f8159e9e-7cd6-4c8c-b487-a986098fde5d")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    [IsoId("52c5a6dd-089a-48f9-9221-a1f61aca8d85")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    [IsoId("a9c5debe-8a3a-4afb-bf28-28dd5901d6f9")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    [IsoId("cddc4dd3-b1d3-42c2-9798-bb7a65b8c8f0")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    [IsoId("1603321d-d1d8-4712-bfb9-c58805abb65d")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    [IsoId("aab5e83f-90d2-497e-90a8-66ee38e0fe56")]
    [DisplayName("Source Of Cash")]
    [IsoXmlTag("SrcOfCsh")]
    public ValueList<SourceOfCash1Choice_> SourceOfCash { get; init; } = [];

    [IsoId("1447ff65-d835-440c-8183-87e69e54853a")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    [IsoId("88f634be-05c3-40b2-88cc-48eb89e80924")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    [IsoId("e6e96ade-4e9b-4161-bd09-b389e7a5fe4f")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    [IsoId("16732378-05c6-48df-a0ca-fb45cc98a964")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
