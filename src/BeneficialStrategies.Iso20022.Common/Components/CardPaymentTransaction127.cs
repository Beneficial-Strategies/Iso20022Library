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
[IsoId("_MZWwAXGWEe2TbaNWBpRZpQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction127
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_MlLlgXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_MlLlg3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType5Code TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_MlLlhXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_MlLlh3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    [IsoId("_MlLliXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_MlLli3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_MlLljXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiator of the request. For instance refers to POITransactionIdentification if used inside an authorisation request or to SaleTransactionIdentification if the message is a payment request initiated by a sale system.
    /// </summary>
    [IsoId("_MlLlj3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_MlMzoXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction126? OriginalTransaction { get; init; }

    /// <summary>
    /// Unique identification of the Acquirer/Acceptor reconciliation period.
    /// </summary>
    [IsoId("_MlMzo3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_MlMzpXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Identification, given by the Issuer, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_MlMzp3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerCITIdentification { get; init; }

    /// <summary>
    /// Identification, given by the merchant, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_MlMzqXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_MlMzq3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails52 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    [IsoId("_MlMzrXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult18? AuthorisationResult { get; init; }

    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    [IsoId("_MlOBwXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Customer Order processing data.
    /// </summary>
    [IsoId("_MlOBw3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Customer payment token information.
    /// </summary>
    [IsoId("_MlOBxXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Customer Token")]
    [IsoXmlTag("CstmrTkn")]
    public CardPaymentToken5? CustomerToken { get; init; }

    /// <summary>
    /// Indicates if the customer has explicitly validated a choice.
    /// </summary>
    [IsoId("_MlOBx3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Specifies the card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_MlOByXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Specifies the card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_MlOBy3GWEe2TbaNWBpRZpQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Specifies element that the sale system wants to store in the POI system.
    /// </summary>
    [IsoId("_MlOBzXGWEe2TbaNWBpRZpQ")]
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    [IsoId("_MlOo0XGWEe2TbaNWBpRZpQ")]
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    [IsoId("_MlOo03GWEe2TbaNWBpRZpQ")]
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToIssuerData { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_MlOo1XGWEe2TbaNWBpRZpQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
