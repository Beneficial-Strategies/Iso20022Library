// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with a transaction process by a Point Of Interaction.
/// </summary>
[IsoId("_UzyEsZ_-EfC4Q_xhaK1hdQ")]
[DisplayName("Payment Transaction183")]
public record PaymentTransaction183
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_U010oZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Set of possible payment instruments from which one will apply to this transaction.
    /// </summary>
    [IsoId("_U010o5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public SimpleValueList<PaymentInstrumentType2Code> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Further details related to the set of payment types.
    /// </summary>
    [IsoId("_U010pZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_U010p5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType16Code TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_U010qZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_U010q5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    [IsoId("_U010rZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_U010r5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_U010sZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiator of the request.
    /// </summary>
    [IsoId("_U010s5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_U010tZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction148? OriginalTransaction { get; init; }

    /// <summary>
    /// Unique identification of the Acquirer/Acceptor reconciliation period.
    /// </summary>
    [IsoId("_U010t5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_U010uZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Identification, given by the Issuer, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_U010u5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    public IsoMax140Text? IssuerCITIdentification { get; init; }

    /// <summary>
    /// Identification, given by the merchant, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_U010vZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    public IsoMax140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_U010v5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails54 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    [IsoId("_U010wZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult18? AuthorisationResult { get; init; }

    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    [IsoId("_U010w5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Customer Order processing data.
    /// </summary>
    [IsoId("_U010xZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Customer payment token information.
    /// </summary>
    [IsoId("_U010x5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Customer Token")]
    [IsoXmlTag("CstmrTkn")]
    public CardPaymentToken5? CustomerToken { get; init; }

    /// <summary>
    /// Indicates if the customer has explicitly validated a choice.
    /// </summary>
    [IsoId("_U010yZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Specifies the card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_U010y5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Specifies the card program actually selected by the cardholder.
    /// </summary>
    [IsoId("_U010zZ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Specifies element that the sale system wants to store in the POI system.
    /// </summary>
    [IsoId("_U010z5_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    public IsoMax70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    [IsoId("_U0100Z_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    public IsoMax70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    [IsoId("_U01005_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    public IsoMax70Text? SaleToIssuerData { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_U0101Z_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];

    /// <summary>
    /// Message from a merchant to be displayed on the cardholder bank statement.
    /// </summary>
    [IsoId("_jNNBUJ_-EfC4Q_xhaK1hdQ")]
    [DisplayName("Message From Merchant")]
    [IsoXmlTag("MsgFrMrchnt")]
    public ValueList<Action18> MessageFromMerchant { get; init; } = [];
}
