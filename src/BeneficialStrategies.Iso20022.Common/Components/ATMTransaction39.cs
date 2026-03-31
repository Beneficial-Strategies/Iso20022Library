// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction39.
/// </summary>
[IsoId("_fm5Z8aEOEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction39")]
public record ATMTransaction39
{
    /// <summary>
    /// Account From.
    /// </summary>
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount19? AccountFrom { get; init; }

    /// <summary>
    /// Account Information.
    /// </summary>
    [DisplayName("Account Information")]
    [IsoXmlTag("AcctInf")]
    public ValueList<CardAccount18> AccountInformation { get; init; } = [];

    /// <summary>
    /// Account To.
    /// </summary>
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public ValueList<CardAccount19> AccountTo { get; init; } = [];

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action7> Action { get; init; } = [];

    /// <summary>
    /// Additional Charge.
    /// </summary>
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public ValueList<DetailedAmount18> AdditionalCharge { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult20? AuthorisationResult { get; init; }

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Creditor Label.
    /// </summary>
    [DisplayName("Creditor Label")]
    [IsoXmlTag("CdtrLabl")]
    public IsoMax35Text? CreditorLabel { get; init; }

    /// <summary>
    /// Debtor Label.
    /// </summary>
    [DisplayName("Debtor Label")]
    [IsoXmlTag("DbtrLabl")]
    public IsoMax35Text? DebtorLabel { get; init; }

    /// <summary>
    /// Detailed Requested Amount.
    /// </summary>
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount17? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Instant Transfer Program.
    /// </summary>
    [DisplayName("Instant Transfer Program")]
    [IsoXmlTag("InstntTrfPrgm")]
    public IsoMax35Text? InstantTransferProgram { get; init; }

    /// <summary>
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; }

    /// <summary>
    /// Payment Reference.
    /// </summary>
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    public IsoMax35Text? PaymentReference { get; init; }

    /// <summary>
    /// Proposed Execution Date.
    /// </summary>
    [DisplayName("Proposed Execution Date")]
    [IsoXmlTag("PropsdExctnDt")]
    public IsoISODate? ProposedExecutionDate { get; init; }

    /// <summary>
    /// Protected Account From.
    /// </summary>
    [DisplayName("Protected Account From")]
    [IsoXmlTag("PrtctdAcctFr")]
    public ContentInformationType10? ProtectedAccountFrom { get; init; }

    /// <summary>
    /// Protected Account To.
    /// </summary>
    [DisplayName("Protected Account To")]
    [IsoXmlTag("PrtctdAcctTo")]
    public ContentInformationType10? ProtectedAccountTo { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Recurring Transfer.
    /// </summary>
    [DisplayName("Recurring Transfer")]
    [IsoXmlTag("RcrngTrf")]
    public RecurringTransaction3? RecurringTransfer { get; init; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Total Requested Amount.
    /// </summary>
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType12 TransactionResponse { get; init; }

    /// <summary>
    /// Transfer Identifier.
    /// </summary>
    [DisplayName("Transfer Identifier")]
    [IsoXmlTag("TrfIdr")]
    public IsoMax70Text? TransferIdentifier { get; init; }
}
