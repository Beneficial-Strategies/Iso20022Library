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
[IsoId("_HW2x4dmsEeeN3v2fup_Shw")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction81
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_HfqvodmsEeeN3v2fup_Shw")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_Hfqvo9msEeeN3v2fup_Shw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_HfqvpdmsEeeN3v2fup_Shw")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_Hfqvp9msEeeN3v2fup_Shw")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_HfqvqdmsEeeN3v2fup_Shw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    [IsoId("_Hfqvq9msEeeN3v2fup_Shw")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public SimpleValueList<IsoTrueFalseIndicator> CustomerConsent { get; init; } = [];

    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_HfqvrdmsEeeN3v2fup_Shw")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_Hfqvr9msEeeN3v2fup_Shw")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public SimpleValueList<IsoMax35Text> CardProgrammeApplied { get; init; } = [];

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_HfqvsdmsEeeN3v2fup_Shw")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Hfqvs9msEeeN3v2fup_Shw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_HfqvtdmsEeeN3v2fup_Shw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction79? OriginalTransaction { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_Hfqvt9msEeeN3v2fup_Shw")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [IsoId("_HfqvudmsEeeN3v2fup_Shw")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    [IsoId("_Hfqvu9msEeeN3v2fup_Shw")]
    [DisplayName("Merchant Override")]
    [IsoXmlTag("MrchntOvrrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverride { get; init; }

    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_HfqvvdmsEeeN3v2fup_Shw")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public SimpleValueList<FailureReason3Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_Hfqvv9msEeeN3v2fup_Shw")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_HfqvwdmsEeeN3v2fup_Shw")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_Hfqvw9msEeeN3v2fup_Shw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_HfqvxdmsEeeN3v2fup_Shw")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_Hfqvx9msEeeN3v2fup_Shw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails44 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    [IsoId("_HfqvydmsEeeN3v2fup_Shw")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult11? AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the performed verifications for the transaction.
    /// </summary>
    [IsoId("_Hfqvy9msEeeN3v2fup_Shw")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    [IsoId("_TfQuINmsEeeN3v2fup_Shw")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount14? AccountFrom { get; init; }

    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    [IsoId("_X054sNmsEeeN3v2fup_Shw")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount14? AccountTo { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_HfqvzdmsEeeN3v2fup_Shw")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
