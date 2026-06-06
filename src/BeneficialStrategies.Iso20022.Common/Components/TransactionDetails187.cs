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
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [IsoId("_hl1Buag_EfCXwLUUylXgrQ")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity3Choice_ TransactionActivity { get; init; }

    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_hl1Bwag_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent26Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_hl1Byag_EfCXwLUUylXgrQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_hl1B0ag_EfCXwLUUylXgrQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_hl1B2ag_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails235? SettlementParameters { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_hl1B4ag_EfCXwLUUylXgrQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_hl1B6ag_EfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_hl1B8ag_EfCXwLUUylXgrQ")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_hl1B-ag_EfCXwLUUylXgrQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_hl1B-6g_EfCXwLUUylXgrQ")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; }

    /// <summary>
    /// Specifies whether the transaction is under Conditional Securities Delivery (CoSD).
    /// </summary>
    [IsoId("_hl1B_ag_EfCXwLUUylXgrQ")]
    [DisplayName("Conditional Securities Delivery")]
    [IsoXmlTag("CondlSctiesDlvry")]
    public IsoYesNoIndicator? ConditionalSecuritiesDelivery { get; init; }

    /// <summary>
    /// Total quantity of financial instrument to be settled.
    /// </summary>
    [IsoId("_hl1B_6g_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled and which will be delivered to/received from the account owner's securities account. It may differ from the instructed settlement quantity based on market tolerance level.
    /// </summary>
    [IsoId("_hl1CAag_EfCXwLUUylXgrQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public FinancialInstrumentQuantity1Choice_? SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_hl1CA6g_EfCXwLUUylXgrQ")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_hl1CBag_EfCXwLUUylXgrQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_hl1CB6g_EfCXwLUUylXgrQ")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_hl1CD6g_EfCXwLUUylXgrQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection20 SettlementAmount { get; init; }

    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_hl1CEag_EfCXwLUUylXgrQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public AmountAndDirection20? SettledAmount { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_hl1CE6g_EfCXwLUUylXgrQ")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection20? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_hl1CFag_EfCXwLUUylXgrQ")]
    [DisplayName("Remaining Settlement Amount")]
    [IsoXmlTag("RmngSttlmAmt")]
    public AmountAndDirection20? RemainingSettlementAmount { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_hl1CF6g_EfCXwLUUylXgrQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection20? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_hl1CH6g_EfCXwLUUylXgrQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_hl1CJ6g_EfCXwLUUylXgrQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required SettlementDate19Choice_ IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is a payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_hl1CL6g_EfCXwLUUylXgrQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_hl1CN6g_EfCXwLUUylXgrQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_hl1CP6g_EfCXwLUUylXgrQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_hl1CR6g_EfCXwLUUylXgrQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("_hl1CSag_EfCXwLUUylXgrQ")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_hl1CS6g_EfCXwLUUylXgrQ")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages57> Linkages { get; init; } = [];

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_hl1CTag_EfCXwLUUylXgrQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_hl1CVag_EfCXwLUUylXgrQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties78? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_hl1CXag_EfCXwLUUylXgrQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties78? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Specifies whether it is the reversal of a previously reported movement.
    /// </summary>
    [IsoId("_hl1CZag_EfCXwLUUylXgrQ")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    public IsoYesNoIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_hl1Cbag_EfCXwLUUylXgrQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_hl1Cb6g_EfCXwLUUylXgrQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_hl1Cd6g_EfCXwLUUylXgrQ")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_hl1Cf6g_EfCXwLUUylXgrQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
