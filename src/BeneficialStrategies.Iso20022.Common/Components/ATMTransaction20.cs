// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which the completion is sent.
/// </summary>
[IsoId("_dgqpUa4TEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
public record ATMTransaction20
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_dsJgka4TEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_dsJgk64TEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; }

    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_dsJgla4TEeWZgJQOa6iKCQ")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason7Code? Incident { get; init; }

    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_dsJgl64TEeWZgJQOa6iKCQ")]
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? IncidentDetail { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_dsJgma4TEeWZgJQOa6iKCQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_dsJgm64TEeWZgJQOa6iKCQ")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_dsJgna4TEeWZgJQOa6iKCQ")]
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; }

    /// <summary>
    /// Explicit consent expressed by a customer on a card-related service proposed by an acquirer or an issuer or any agent acting on behalf of one of them.
    /// </summary>
    [IsoId("_AG02gPysEeWVMqALyuondw")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_dsJgoa4TEeWZgJQOa6iKCQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult13? AuthorisationResult { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_dsJgo64TEeWZgJQOa6iKCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
