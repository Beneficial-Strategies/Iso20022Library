// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the deposit request.
/// </summary>
[IsoId("_0Rvq4a4HEeWL1uap3dNhCQ")]
[DisplayName("ATM Transaction")]
public record ATMTransaction16
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_0cneIa4HEeWL1uap3dNhCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_0cneI64HEeWL1uap3dNhCQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// True if a completion advice has to be sent after the end of the transaction.
    /// </summary>
    [IsoId("_Aq-RYK4IEeWL1uap3dNhCQ")]
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; }

    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_0cneJa4HEeWL1uap3dNhCQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount10? AccountData { get; init; }

    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_0cneJ64HEeWL1uap3dNhCQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; }

    /// <summary>
    /// Total authorised amount of the deposit transaction.
    /// </summary>
    [IsoId("_0cneKa4HEeWL1uap3dNhCQ")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_ulFNkK4IEeWL1uap3dNhCQ")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; }

    /// <summary>
    /// Detail of the requested amounts for the deposit transaction.
    /// </summary>
    [IsoId("_0cneK64HEeWL1uap3dNhCQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount16? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_59U4MK4IEeWL1uap3dNhCQ")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public DetailedAmount13? AdditionalCharge { get; init; }

    /// <summary>
    /// Outcome of the deposit authorisation.
    /// </summary>
    [IsoId("__BUWgK4IEeWL1uap3dNhCQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult13? AuthorisationResult { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_0cneMa4HEeWL1uap3dNhCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_EbeSEK4JEeWL1uap3dNhCQ")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand7? Command { get; init; }
}
