// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the completion advice message.
/// </summary>
[IsoId("_myadATJIEeOkpIB9tKITlw")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction25
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_nBSmgTJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_nBSmgzJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType5Code TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_nBSmhTJIEeOkpIB9tKITlw")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType6Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_nBSmhzJIEeOkpIB9tKITlw")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_nBSmiTJIEeOkpIB9tKITlw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_rwB4kE4KEeORpcABTQJgwA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_nBSmizJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_nBSmjTJIEeOkpIB9tKITlw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction21? OriginalTransaction { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_nBSmjzJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been appoved by the acquirer.
    /// </summary>
    [IsoId("_nBSmkTJIEeOkpIB9tKITlw")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    [IsoId("_nBSmkzJIEeOkpIB9tKITlw")]
    [DisplayName("Merchant Override")]
    [IsoXmlTag("MrchntOvrrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverride { get; init; }

    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_nBSmlTJIEeOkpIB9tKITlw")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public SimpleValueList<FailureReason3Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_nBSmlzJIEeOkpIB9tKITlw")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_nBSmmTJIEeOkpIB9tKITlw")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_nBSmmzJIEeOkpIB9tKITlw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_nBSmnTJIEeOkpIB9tKITlw")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterchangeData { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_nBSmnzJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails14 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    [IsoId("_nBSmoTJIEeOkpIB9tKITlw")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult2? AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_nBSmozJIEeOkpIB9tKITlw")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult2? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_nBSmpTJIEeOkpIB9tKITlw")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
