// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction for a potential currency conversion.
/// </summary>
[IsoId("_tDoEUQuiEeqw5uEXxQ9H4g")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction100
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_tOVfgQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_tOVfgwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType5Code TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_tOVfhQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType9Code? AdditionalService { get; init; }

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_tOVfhwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    [IsoId("_tOVfiQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_tOVfiwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_tOVfjQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiator of the request. For instance refers to POITransactionIdentification if used inside an authorisation request or to SaleTransactionIdentification if the message is a payment request initiated by a sale system.
    /// </summary>
    [IsoId("_tOVfjwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_tOVfkQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction102? OriginalTransaction { get; init; }

    /// <summary>
    /// Unique identification of the Acquirer/Acceptor reconciliation period.
    /// </summary>
    [IsoId("_tOVfkwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_tOVflQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_tOVflwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails48 TransactionDetails { get; init; }

    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    [IsoId("_tOVfmQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Customer Order processing data.
    /// </summary>
    [IsoId("_tOVfmwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Customer payment token information.
    /// </summary>
    [IsoId("_tOVfnQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Customer Token")]
    [IsoXmlTag("CstmrTkn")]
    public CardPaymentToken5? CustomerToken { get; init; }

    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    [IsoId("_tOVfnwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_tOVfoQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProgrammeProposed { get; init; }

    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_tOVfowuiEeqw5uEXxQ9H4g")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// The POI System receives this information.
    /// </summary>
    [IsoId("_tOVfpQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    [IsoId("_tOVfpwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    [IsoId("_tOVfqQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToIssuerData { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_tOVfqwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionData { get; init; }
}
