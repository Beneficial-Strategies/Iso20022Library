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
[IsoId("6fd54e09-cdfd-45ce-bd4a-2a73b3ba6300")]
[DisplayName("Securities Trade Details152")]
public record SecuritiesTradeDetails152
{
    [IsoId("b2b3dc3e-9bbc-466b-a362-6ac611769150")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    [IsoId("93286a66-80b1-4e26-894d-dcb51cf15b0f")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("6b506da7-b008-4e48-8465-b284bce54f63")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("3ddadedc-a3b0-4e0d-b9c0-1edfd4657b7f")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("3a33b2b9-1a10-492a-81c2-332bf8600111")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("28ac7db4-26f9-46e3-ac82-9bbe93cbeda0")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("09e2f61d-487a-402c-a824-8afd95333481")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("fd7f5df4-744d-4b90-b7e9-52b8a8c7b667")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("b60f81be-1f0c-4859-8d5e-ff254ebed89c")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("e2b1f421-1e42-4967-86fb-f7263713320f")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    [IsoId("f83a4c3f-4c6b-4bef-83ff-bfe09f1c2924")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    [IsoId("4304ceb5-01fb-4413-979e-aff1256df1c9")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    [IsoId("ff135652-606f-4def-8cbb-12dc7a061bfa")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AllegementStatus3Choice_? Status { get; init; }

    [IsoId("6a2e2850-66c7-4ae0-8ebc-69bb012b0342")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("762b1f20-e36e-41bb-9ce4-3d0530adf76f")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("e182fefe-99f7-43de-917d-4fdad8eae403")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    [IsoId("a6f125af-8266-4b05-bb81-31bb4cc322b1")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice_ SettlementDate { get; init; }

    [IsoId("6598f7e8-d3cb-4f38-ae33-611ab9acef94")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price10? DealPrice { get; init; }

    [IsoId("2bf40498-f2dd-4c73-aaa3-eb0c22b89fe7")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("8155021d-3a52-488c-9a68-7457cdda440d")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    [IsoId("fbb42a4a-e6ac-4af0-ba46-ef0011380040")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    [IsoId("ee912099-9d5a-460d-829b-73fff22752fa")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } = [];

    [IsoId("7837d5f8-c8dc-4711-b78d-c025e2e715d1")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; }

    [IsoId("7cc60469-b62a-4165-9101-743a682f4ce6")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount114 QuantityAndAccountDetails { get; init; }

    [IsoId("9e2a8d71-c71d-441f-9687-0bf9266112c7")]
    [DisplayName("Securities Financing Details")]
    [IsoXmlTag("SctiesFincgDtls")]
    public SecuritiesFinancingTransactionDetails54? SecuritiesFinancingDetails { get; init; }

    [IsoId("836915e9-4a8d-4b67-a87f-5f5b07913ddb")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails234 SettlementParameters { get; init; }

    [IsoId("b5bb303f-23f5-4ad0-87d4-e20525dea7ae")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties126? DeliveringSettlementParties { get; init; }

    [IsoId("f9cd0abd-4c05-46d2-9144-7d7d8850f8bc")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties126? ReceivingSettlementParties { get; init; }

    [IsoId("e4c4e14b-7c58-4855-a8d5-98bc6d399bc1")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection88? SettlementAmount { get; init; }

    [IsoId("b848ec92-b293-4394-b6f1-4022d455298a")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts32? OtherAmounts { get; init; }

    [IsoId("_vJFKkZaUEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public ValueList<DigitalPaymentSettlement1> DigitalPaymentSettlement { get; init; } = [];

    [IsoId("9be67119-e55e-4e22-9197-1bedfa1e0421")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties34? OtherBusinessParties { get; init; }

    [IsoId("3bae6917-9049-48c4-9de8-d43c96e16c15")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
