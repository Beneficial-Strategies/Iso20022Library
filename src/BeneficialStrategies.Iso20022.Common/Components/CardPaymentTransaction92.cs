// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction during the authorisation.
/// </summary>
[IsoId("_JhACsQuJEeqYM5yH99IYQw")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction92
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_JrYGsQuJEeqYM5yH99IYQw")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_JrYGswuJEeqYM5yH99IYQw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_JrYGtQuJEeqYM5yH99IYQw")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_JrYGtwuJEeqYM5yH99IYQw")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    [IsoId("_JrYGuQuJEeqYM5yH99IYQw")]
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_JrYGuwuJEeqYM5yH99IYQw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    [IsoId("_JrYGvQuJEeqYM5yH99IYQw")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public SimpleValueList<IsoTrueFalseIndicator> CustomerConsent { get; init; } = [];

    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_JrYGvwuJEeqYM5yH99IYQw")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_JrYGwQuJEeqYM5yH99IYQw")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_JrYGwwuJEeqYM5yH99IYQw")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_JrYGxQuJEeqYM5yH99IYQw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_JrYGxwuJEeqYM5yH99IYQw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction101? OriginalTransaction { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_JrYGyQuJEeqYM5yH99IYQw")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_JrYGywuJEeqYM5yH99IYQw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_JrYGzQuJEeqYM5yH99IYQw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails48 TransactionDetails { get; init; }

    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    [IsoId("_JrYGzwuJEeqYM5yH99IYQw")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    [IsoId("_JrYG0QuJEeqYM5yH99IYQw")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount15? AccountFrom { get; init; }

    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    [IsoId("_JrYG0wuJEeqYM5yH99IYQw")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount15? AccountTo { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_JrYG1QuJEeqYM5yH99IYQw")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
