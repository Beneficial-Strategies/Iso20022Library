// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria based on which information is included.
/// </summary>
[IsoId("_WmNI4agzEfCXwLUUylXgrQ")]
[DisplayName("Settlement Instruction Query Criteria4")]
public record SettlementInstructionQueryCriteria4
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Wp7LQagzEfCXwLUUylXgrQ")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<References83Choice_> References { get; init; } = [];

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_Wp7LSagzEfCXwLUUylXgrQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<SettlementInstructionQueryStatus3> Status { get; init; } = [];

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_Wp7LS6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public SimpleValueList<ReceiveDelivery1Code> SecuritiesMovementType { get; init; } = [];

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_Wp7LWagzEfCXwLUUylXgrQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public SimpleValueList<DeliveryReceiptType2Code> Payment { get; init; } = [];

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_Wp7yU6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public ValueList<SecuritiesTransactionType48Choice_> SecuritiesTransactionType { get; init; } = [];

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Wp7yW6gzEfCXwLUUylXgrQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } = [];

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_Wp7yY6gzEfCXwLUUylXgrQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<PriorityNumeric4Choice_> Priority { get; init; } = [];

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_Wp7ya6gzEfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public ValueList<SecuritiesAccount19> SafekeepingAccount { get; init; } = [];

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_Wp7ybagzEfCXwLUUylXgrQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> CashAccount { get; init; } = [];

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_Wp7yb6gzEfCXwLUUylXgrQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTimeSearch5Choice_? TradeDate { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_Wp7yd6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public QuantitySearch2Choice_? SettlementQuantity { get; init; }

    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_Wp7yf6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public QuantitySearch2Choice_? SettledQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_Wp7yh6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmountRange3? SettlementAmount { get; init; }

    /// <summary>
    /// Total amount of money paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_Wp7yj6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public ActiveCurrencyAndAmountRange3? SettledAmount { get; init; }

    /// <summary>
    /// Date on which a transaction is expected to settle. That is, the intended day on which transfer of cash or assets is completed.
    /// </summary>
    [IsoId("_Wp7yl6gzEfCXwLUUylXgrQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public DateAndDateTimeSearch5Choice_? IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is a payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_Wp8ZYagzEfCXwLUUylXgrQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeSearch5Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    [IsoId("_Wp8ZaagzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> SettlementCurrency { get; init; } = [];

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_Wp8Za6gzEfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account Owner")]
    [IsoXmlTag("SfkpgAcctOwnr")]
    public ValueList<PartyIdentification148> SafekeepingAccountOwner { get; init; } = [];

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Wp8ZbagzEfCXwLUUylXgrQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Identifies the chain of counterparty settlement parties.
    /// </summary>
    [IsoId("_Wp8Zb6gzEfCXwLUUylXgrQ")]
    [DisplayName("Counterpart Settlement Parties")]
    [IsoXmlTag("CntrptSttlmPties")]
    public ValueList<SettlementParties78> CounterpartSettlementParties { get; init; } = [];

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_Wp8ZcagzEfCXwLUUylXgrQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public ValueList<SettlementParties78> DeliveringSettlementParties { get; init; } = [];

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_Wp8ZeagzEfCXwLUUylXgrQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public ValueList<SettlementParties78> ReceivingSettlementParties { get; init; } = [];

    /// <summary>
    /// Provides the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_Wp8ZgagzEfCXwLUUylXgrQ")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public SimpleValueList<TradeTransactionCondition1Code> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_Wp8Zg6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Transaction Condition")]
    [IsoXmlTag("SctiesTxCond")]
    public ValueList<SettlementTransactionCondition34Choice_> SecuritiesTransactionCondition { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_Wp8ZhagzEfCXwLUUylXgrQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the transaction is under Conditional Securities Delivery (CoSD).
    /// </summary>
    [IsoId("_Wp8Zh6gzEfCXwLUUylXgrQ")]
    [DisplayName("Conditional Securities Delivery")]
    [IsoXmlTag("CondlSctiesDlvry")]
    public IsoYesNoIndicator? ConditionalSecuritiesDelivery { get; init; }

    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_Wp8ZiagzEfCXwLUUylXgrQ")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public SimpleValueList<CountryCode> CountryOfIssue { get; init; } = [];

    /// <summary>
    /// Central securities depository (CSD) in which financial instruments are issued (or immobilised). The issuer CSD opens accounts allowing investors (in a direct holding system) and/or intermediaries (including investor CSDs) to hold these financial instruments.
    /// </summary>
    [IsoId("_Wp8ZkagzEfCXwLUUylXgrQ")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    public ValueList<PartyIdentification136> IssuerCSD { get; init; } = [];

    /// <summary>
    /// Specifies whether the transaction is on hold, blocked or frozen.
    /// </summary>
    [IsoId("_Wp8Zk6gzEfCXwLUUylXgrQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public ValueList<Registration10Choice_> HoldIndicator { get; init; } = [];
}
