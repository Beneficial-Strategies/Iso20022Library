// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction38.
/// </summary>
[IsoId("_ayTkoaCBEe-mUP79iiSLcw")]
[DisplayName("ATM Transaction38")]
public record ATMTransaction38
{
    /// <summary>
    /// Account From.
    /// </summary>
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount20? AccountFrom { get; init; }

    /// <summary>
    /// Account To.
    /// </summary>
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public ValueList<CardAccount20> AccountTo { get; init; } = [];

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
    /// Payment Reference.
    /// </summary>
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    public IsoMax35Text? PaymentReference { get; init; }

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
    /// Requested Receipt.
    /// </summary>
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

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
}
