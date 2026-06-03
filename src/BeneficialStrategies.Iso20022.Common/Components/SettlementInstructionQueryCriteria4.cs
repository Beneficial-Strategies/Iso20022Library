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
    [IsoId("_Wp7LQagzEfCXwLUUylXgrQ")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<References83Choice> References { get; init; } = [];

    [IsoId("_Wp7LSagzEfCXwLUUylXgrQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<SettlementInstructionQueryStatus3> Status { get; init; } = [];

    [IsoId("_Wp7LS6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public SimpleValueList<ReceiveDelivery1Code> SecuritiesMovementType { get; init; } = [];

    [IsoId("_Wp7LWagzEfCXwLUUylXgrQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public SimpleValueList<DeliveryReceiptType2Code> Payment { get; init; } = [];

    [IsoId("_Wp7yU6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public ValueList<SecuritiesTransactionType48Choice> SecuritiesTransactionType { get; init; } = [];

    [IsoId("_Wp7yW6gzEfCXwLUUylXgrQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } = [];

    [IsoId("_Wp7yY6gzEfCXwLUUylXgrQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<PriorityNumeric4Choice> Priority { get; init; } = [];

    [IsoId("_Wp7ya6gzEfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public ValueList<SecuritiesAccount19> SafekeepingAccount { get; init; } = [];

    [IsoId("_Wp7ybagzEfCXwLUUylXgrQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public ValueList<AccountIdentificationSearchCriteria2Choice> CashAccount { get; init; } = [];

    [IsoId("_Wp7yb6gzEfCXwLUUylXgrQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTimeSearch5Choice? TradeDate { get; init; }

    [IsoId("_Wp7yd6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public QuantitySearch2Choice? SettlementQuantity { get; init; }

    [IsoId("_Wp7yf6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public QuantitySearch2Choice? SettledQuantity { get; init; }

    [IsoId("_Wp7yh6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmountRange3? SettlementAmount { get; init; }

    [IsoId("_Wp7yj6gzEfCXwLUUylXgrQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public ActiveCurrencyAndAmountRange3? SettledAmount { get; init; }

    [IsoId("_Wp7yl6gzEfCXwLUUylXgrQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public DateAndDateTimeSearch5Choice? IntendedSettlementDate { get; init; }

    [IsoId("_Wp8ZYagzEfCXwLUUylXgrQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeSearch5Choice? EffectiveSettlementDate { get; init; }

    [IsoId("_Wp8ZaagzEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> SettlementCurrency { get; init; } = [];

    [IsoId("_Wp8Za6gzEfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account Owner")]
    [IsoXmlTag("SfkpgAcctOwnr")]
    public ValueList<PartyIdentification148> SafekeepingAccountOwner { get; init; } = [];

    [IsoId("_Wp8ZbagzEfCXwLUUylXgrQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    [IsoId("_Wp8Zb6gzEfCXwLUUylXgrQ")]
    [DisplayName("Counterpart Settlement Parties")]
    [IsoXmlTag("CntrptSttlmPties")]
    public ValueList<SettlementParties78> CounterpartSettlementParties { get; init; } = [];

    [IsoId("_Wp8ZcagzEfCXwLUUylXgrQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public ValueList<SettlementParties78> DeliveringSettlementParties { get; init; } = [];

    [IsoId("_Wp8ZeagzEfCXwLUUylXgrQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public ValueList<SettlementParties78> ReceivingSettlementParties { get; init; } = [];

    [IsoId("_Wp8ZgagzEfCXwLUUylXgrQ")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public SimpleValueList<TradeTransactionCondition1Code> TradeTransactionCondition { get; init; } = [];

    [IsoId("_Wp8Zg6gzEfCXwLUUylXgrQ")]
    [DisplayName("Securities Transaction Condition")]
    [IsoXmlTag("SctiesTxCond")]
    public ValueList<SettlementTransactionCondition34Choice> SecuritiesTransactionCondition { get; init; } = [];

    [IsoId("_Wp8ZhagzEfCXwLUUylXgrQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    [IsoId("_Wp8Zh6gzEfCXwLUUylXgrQ")]
    [DisplayName("Conditional Securities Delivery")]
    [IsoXmlTag("CondlSctiesDlvry")]
    public IsoYesNoIndicator? ConditionalSecuritiesDelivery { get; init; }

    [IsoId("_Wp8ZiagzEfCXwLUUylXgrQ")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public SimpleValueList<CountryCode> CountryOfIssue { get; init; } = [];

    [IsoId("_Wp8ZkagzEfCXwLUUylXgrQ")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    public ValueList<PartyIdentification136> IssuerCSD { get; init; } = [];

    [IsoId("_Wp8Zk6gzEfCXwLUUylXgrQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public ValueList<Registration10Choice> HoldIndicator { get; init; } = [];
}
