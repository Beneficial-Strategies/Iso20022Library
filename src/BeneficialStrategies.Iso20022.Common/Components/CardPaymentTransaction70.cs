// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the batch capture.
/// </summary>
[IsoId("_z2H-Ya16EeawR4FMacHsRQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction70
{
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_0CIaEa16EeawR4FMacHsRQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType5Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_0CJBIa16EeawR4FMacHsRQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_0CJBI616EeawR4FMacHsRQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_0CJBJa16EeawR4FMacHsRQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    [IsoId("_WtUVkLLzEeaRnrUTla0j3A")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public SimpleValueList<IsoTrueFalseIndicator> CustomerConsent { get; init; } = [];

    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_di9-wLLzEeaRnrUTla0j3A")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_Y58IsLL0EeaRnrUTla0j3A")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public SimpleValueList<IsoMax35Text> CardProgrammeApplied { get; init; } = [];

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_0CJBJ616EeawR4FMacHsRQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_0CJBKa16EeawR4FMacHsRQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_0CJBK616EeawR4FMacHsRQ")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction52? OriginalTransaction { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_0CJBLa16EeawR4FMacHsRQ")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [IsoId("_0CJBL616EeawR4FMacHsRQ")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    [IsoId("_0CJBMa16EeawR4FMacHsRQ")]
    [DisplayName("Merchant Override")]
    [IsoXmlTag("MrchntOvrrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverride { get; init; }

    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_0CJBM616EeawR4FMacHsRQ")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public SimpleValueList<FailureReason3Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_0CJBNa16EeawR4FMacHsRQ")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_0CJBN616EeawR4FMacHsRQ")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_0CJBOa16EeawR4FMacHsRQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_0CJBO616EeawR4FMacHsRQ")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_0CJBPa16EeawR4FMacHsRQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails38 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request, and actions to perform.
    /// </summary>
    [IsoId("_0CJBP616EeawR4FMacHsRQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult10? AuthorisationResult { get; init; }

    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_0CJBQa16EeawR4FMacHsRQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_0CJBQ616EeawR4FMacHsRQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
