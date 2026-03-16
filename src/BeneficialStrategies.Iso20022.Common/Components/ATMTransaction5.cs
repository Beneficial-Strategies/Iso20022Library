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
[IsoId("_BgABgYqoEeS4a4abTJTSSw")]
[DisplayName("ATM Transaction")]
public record ATMTransaction5
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_BsEHkYqoEeS4a4abTJTSSw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_BsEHk4qoEeS4a4abTJTSSw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; }

    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_BsEHnYqoEeS4a4abTJTSSw")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public SimpleValueList<FailureReason4Code> Incident { get; init; } = [];

    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_AvPyoCvNEeW-qbryg71zJw")]
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    public SimpleValueList<IsoMax70Text> IncidentDetail { get; init; } = [];

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_BsEHn4qoEeS4a4abTJTSSw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_BsEHp4qoEeS4a4abTJTSSw")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_BsEHqYqoEeS4a4abTJTSSw")]
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; }

    /// <summary>
    /// True when the card was captured by the ATM.
    /// </summary>
    [IsoId("_BsEHq4qoEeS4a4abTJTSSw")]
    [DisplayName("Captured Card")]
    [IsoXmlTag("CaptrdCard")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CapturedCard { get; init; }

    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_BsEHsYqoEeS4a4abTJTSSw")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult9? AuthorisationResult { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_BsEHs4qoEeS4a4abTJTSSw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
