// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies further details of the transaction for which the penalties apply.
/// </summary>
[IsoId("_gkJhQahKEfCXwLUUylXgrQ")]
[DisplayName("Penalty Transaction Record2")]
public record PenaltyTransactionRecord2
{
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_gnskgKhKEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public required SettlementOrCorporateActionEvent27Choice SettlementTransactionOrCorporateActionEventType { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_gnskiKhKEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice SettlementDate { get; init; }

    /// <summary>
    /// Date related to a corporate action event.
    /// </summary>
    [IsoId("_gnskjKhKEfCXwLUUylXgrQ")]
    [DisplayName("Corporate Action Related Date")]
    [IsoXmlTag("CorpActnRltdDt")]
    public DateAndDateTime2Choice? CorporateActionRelatedDate { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_gnskjqhKEfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_gnsklqhKEfCXwLUUylXgrQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_gnsknqhKEfCXwLUUylXgrQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_gnskrKhKEfCXwLUUylXgrQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Quantity of financial instruments making up to the lot.
    /// </summary>
    [IsoId("_gnskuqhKEfCXwLUUylXgrQ")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required FinancialInstrumentQuantity1Choice PostingQuantity { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_gnskwqhKEfCXwLUUylXgrQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice? CashAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_gnskyqhKEfCXwLUUylXgrQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public PartyIdentification272? CashAccountOwner { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_gnsk5KhKEfCXwLUUylXgrQ")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public AmountAndDirection5? PostingAmount { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_gnsk6KhKEfCXwLUUylXgrQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("_gnsk6qhKEfCXwLUUylXgrQ")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    /// <summary>
    /// Instruction is failing.
    /// </summary>
    [IsoId("_gnsk7KhKEfCXwLUUylXgrQ")]
    [DisplayName("Settlement Status Failing")]
    [IsoXmlTag("SttlmStsFlng")]
    public FailingStatus15Choice? SettlementStatusFailing { get; init; }

    /// <summary>
    /// System event relevant to the computation of the penalty.
    /// </summary>
    [IsoId("_gnsk9KhKEfCXwLUUylXgrQ")]
    [DisplayName("Business Day Event")]
    [IsoXmlTag("BizDayEvt")]
    public SystemEvent3? BusinessDayEvent { get; init; }
}
