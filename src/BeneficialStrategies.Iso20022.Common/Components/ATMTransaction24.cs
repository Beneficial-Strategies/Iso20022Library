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
[IsoId("_Ez0uka4zEeWpsoxRhdX-8A")]
[DisplayName("ATM Transaction")]
public record ATMTransaction24
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_E_40oa4zEeWpsoxRhdX-8A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_E_40pa4zEeWpsoxRhdX-8A")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Description of the transfer for the creditor.
    /// </summary>
    [IsoId("_E_40p64zEeWpsoxRhdX-8A")]
    [DisplayName("Creditor Label")]
    [IsoXmlTag("CdtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorLabel { get; init; }

    /// <summary>
    /// Description of the transfer for the debtor.
    /// </summary>
    [IsoId("_E_40qa4zEeWpsoxRhdX-8A")]
    [DisplayName("Debtor Label")]
    [IsoXmlTag("DbtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorLabel { get; init; }

    /// <summary>
    /// Identifier of the approved transfer transaction for the bank.
    /// </summary>
    [IsoId("_dSkVYK4zEeWpsoxRhdX-8A")]
    [DisplayName("Transfer Identifier")]
    [IsoXmlTag("TrfIdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TransferIdentifier { get; init; }

    /// <summary>
    /// Reference of the payment.
    /// </summary>
    [IsoId("_E_40q64zEeWpsoxRhdX-8A")]
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentReference { get; init; }

    /// <summary>
    /// Result of the fund transfer request.
    /// </summary>
    [IsoId("_m6ZyUK4zEeWpsoxRhdX-8A")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType7 TransactionResponse { get; init; }

    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_smZr0K4zEeWpsoxRhdX-8A")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action7> Action { get; init; } = [];

    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    [IsoId("_E_40ra4zEeWpsoxRhdX-8A")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount13? AccountFrom { get; init; }

    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    [IsoId("_E_40r64zEeWpsoxRhdX-8A")]
    [DisplayName("Protected Account From")]
    [IsoXmlTag("PrtctdAcctFr")]
    public ContentInformationType10? ProtectedAccountFrom { get; init; }

    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    [IsoId("_E_40sa4zEeWpsoxRhdX-8A")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public ValueList<CardAccount13> AccountTo { get; init; } = [];

    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    [IsoId("_E_40s64zEeWpsoxRhdX-8A")]
    [DisplayName("Protected Account To")]
    [IsoXmlTag("PrtctdAcctTo")]
    public ContentInformationType10? ProtectedAccountTo { get; init; }

    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_lca78K40EeWpsoxRhdX-8A")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_E_40ta4zEeWpsoxRhdX-8A")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; }

    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    [IsoId("_E_40t64zEeWpsoxRhdX-8A")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount17? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_vu1m8K40EeWpsoxRhdX-8A")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public ValueList<DetailedAmount18> AdditionalCharge { get; init; } = [];

    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_MlN8YK41EeWpsoxRhdX-8A")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; }

    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    [IsoId("_E_40ua4zEeWpsoxRhdX-8A")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Proposed date of the execution of the transfer.
    /// </summary>
    [IsoId("_RhPxgK41EeWpsoxRhdX-8A")]
    [DisplayName("Proposed Execution Date")]
    [IsoXmlTag("PropsdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProposedExecutionDate { get; init; }

    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    [IsoId("_E_40u64zEeWpsoxRhdX-8A")]
    [DisplayName("Instant Transfer Program")]
    [IsoXmlTag("InstntTrfPrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstantTransferProgram { get; init; }

    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    [IsoId("_E_40va4zEeWpsoxRhdX-8A")]
    [DisplayName("Recurring Transfer")]
    [IsoXmlTag("RcrngTrf")]
    public RecurringTransaction3? RecurringTransfer { get; init; }

    /// <summary>
    /// Outcome of the transfer authorisation.
    /// </summary>
    [IsoId("_aHrb0K41EeWpsoxRhdX-8A")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult13? AuthorisationResult { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_E_40wa4zEeWpsoxRhdX-8A")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_irfP8K41EeWpsoxRhdX-8A")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];
}
