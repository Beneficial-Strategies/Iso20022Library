// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies additional details of the transaction.
/// </summary>
[IsoId("_himukag_EfCXwLUUylXgrQ")]
[DisplayName("Transaction Details187")]
public record TransactionDetails187
{
    [IsoId("_hl1Buag_EfCXwLUUylXgrQ")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity3Choice_ TransactionActivity { get; init; }

    [IsoId("_hl1Bwag_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent26Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    [IsoId("_hl1Byag_EfCXwLUUylXgrQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    [IsoId("_hl1B0ag_EfCXwLUUylXgrQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    [IsoId("_hl1B2ag_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails235? SettlementParameters { get; init; }

    [IsoId("_hl1B4ag_EfCXwLUUylXgrQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("_hl1B6ag_EfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; }

    [IsoId("_hl1B8ag_EfCXwLUUylXgrQ")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("_hl1B-ag_EfCXwLUUylXgrQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    [IsoId("_hl1B-6g_EfCXwLUUylXgrQ")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; }

    [IsoId("_hl1B_ag_EfCXwLUUylXgrQ")]
    [DisplayName("Conditional Securities Delivery")]
    [IsoXmlTag("CondlSctiesDlvry")]
    public IsoYesNoIndicator? ConditionalSecuritiesDelivery { get; init; }

    [IsoId("_hl1B_6g_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    [IsoId("_hl1CAag_EfCXwLUUylXgrQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public FinancialInstrumentQuantity1Choice_? SettledQuantity { get; init; }

    [IsoId("_hl1CA6g_EfCXwLUUylXgrQ")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    [IsoId("_hl1CBag_EfCXwLUUylXgrQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    [IsoId("_hl1CB6g_EfCXwLUUylXgrQ")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("_hl1CD6g_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection20 SettlementAmount { get; init; }

    [IsoId("_hl1CEag_EfCXwLUUylXgrQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public AmountAndDirection20? SettledAmount { get; init; }

    [IsoId("_hl1CE6g_EfCXwLUUylXgrQ")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection20? PreviouslySettledAmount { get; init; }

    [IsoId("_hl1CFag_EfCXwLUUylXgrQ")]
    [DisplayName("Remaining Settlement Amount")]
    [IsoXmlTag("RmngSttlmAmt")]
    public AmountAndDirection20? RemainingSettlementAmount { get; init; }

    [IsoId("_hl1CF6g_EfCXwLUUylXgrQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection20? AccruedInterestAmount { get; init; }

    [IsoId("_hl1CH6g_EfCXwLUUylXgrQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    [IsoId("_hl1CJ6g_EfCXwLUUylXgrQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required SettlementDate19Choice_ IntendedSettlementDate { get; init; }

    [IsoId("_hl1CL6g_EfCXwLUUylXgrQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    [IsoId("_hl1CN6g_EfCXwLUUylXgrQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    [IsoId("_hl1CP6g_EfCXwLUUylXgrQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    [IsoId("_hl1CR6g_EfCXwLUUylXgrQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    [IsoId("_hl1CSag_EfCXwLUUylXgrQ")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    [IsoId("_hl1CS6g_EfCXwLUUylXgrQ")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages57> Linkages { get; init; } = [];

    [IsoId("_hl1CTag_EfCXwLUUylXgrQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    [IsoId("_hl1CVag_EfCXwLUUylXgrQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties78? DeliveringSettlementParties { get; init; }

    [IsoId("_hl1CXag_EfCXwLUUylXgrQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties78? ReceivingSettlementParties { get; init; }

    [IsoId("_hl1CZag_EfCXwLUUylXgrQ")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    public IsoYesNoIndicator? ReversalIndicator { get; init; }

    [IsoId("_hl1Cbag_EfCXwLUUylXgrQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    [IsoId("_hl1Cb6g_EfCXwLUUylXgrQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    [IsoId("_hl1Cd6g_EfCXwLUUylXgrQ")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; }

    [IsoId("_hl1Cf6g_EfCXwLUUylXgrQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
