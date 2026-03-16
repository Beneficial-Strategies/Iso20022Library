// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer information for the transaction.
/// </summary>
[IsoId("_t-Wk8a4tEeWLdt0vLARX2Q")]
[DisplayName("ATM Transaction")]
public record ATMTransaction23
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_uJO_Qa4tEeWLdt0vLARX2Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_uJO_Ra4tEeWLdt0vLARX2Q")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Description of the transfer for the creditor.
    /// </summary>
    [IsoId("_GgHqkK4uEeWLdt0vLARX2Q")]
    [DisplayName("Creditor Label")]
    [IsoXmlTag("CdtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorLabel { get; init; }

    /// <summary>
    /// Description of the transfer for the debtor.
    /// </summary>
    [IsoId("_JmHLIK4uEeWLdt0vLARX2Q")]
    [DisplayName("Debtor Label")]
    [IsoXmlTag("DbtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorLabel { get; init; }

    /// <summary>
    /// Reference of the payment.
    /// </summary>
    [IsoId("_QDmzAK4uEeWLdt0vLARX2Q")]
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentReference { get; init; }

    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    [IsoId("_uJO_Ta4tEeWLdt0vLARX2Q")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount7? AccountFrom { get; init; }

    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    [IsoId("_uJO_T64tEeWLdt0vLARX2Q")]
    [DisplayName("Protected Account From")]
    [IsoXmlTag("PrtctdAcctFr")]
    public ContentInformationType10? ProtectedAccountFrom { get; init; }

    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    [IsoId("_dtODUK4uEeWLdt0vLARX2Q")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public ValueList<CardAccount7> AccountTo { get; init; } = [];

    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    [IsoId("_iK1eIK4uEeWLdt0vLARX2Q")]
    [DisplayName("Protected Account To")]
    [IsoXmlTag("PrtctdAcctTo")]
    public ContentInformationType10? ProtectedAccountTo { get; init; }

    /// <summary>
    /// Amount of the transaction to be authorised.
    /// </summary>
    [IsoId("_uJO_Va4tEeWLdt0vLARX2Q")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; }

    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    [IsoId("_uJO_V64tEeWLdt0vLARX2Q")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount17? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    [IsoId("_RQ724K4wEeWpsoxRhdX-8A")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    [IsoId("_WXYMQK4wEeWpsoxRhdX-8A")]
    [DisplayName("Instant Transfer Program")]
    [IsoXmlTag("InstntTrfPrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstantTransferProgram { get; init; }

    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    [IsoId("_aYAJEK4wEeWpsoxRhdX-8A")]
    [DisplayName("Recurring Transfer")]
    [IsoXmlTag("RcrngTrf")]
    public RecurringTransaction3? RecurringTransfer { get; init; }

    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_uJO_W64tEeWLdt0vLARX2Q")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_uJO_aa4tEeWLdt0vLARX2Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
