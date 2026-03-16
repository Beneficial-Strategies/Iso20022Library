// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction165.
/// </summary>
[IsoId("_kTMHYKWXEe-ymImuWN-uZA")]
[DisplayName("Payment Transaction165")]
public record PaymentTransaction165
{
    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional Transaction Data.
    /// </summary>
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public ValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult18? AuthorisationResult { get; init; }

    /// <summary>
    /// Card Programme Applied.
    /// </summary>
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Card Programme Proposed.
    /// </summary>
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public ValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Customer Consent.
    /// </summary>
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Customer Token.
    /// </summary>
    [DisplayName("Customer Token")]
    [IsoXmlTag("CstmrTkn")]
    public CardPaymentToken5? CustomerToken { get; init; }

    /// <summary>
    /// Issuer CIT Identification.
    /// </summary>
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    public IsoMax140Text? IssuerCITIdentification { get; init; }

    /// <summary>
    /// Issuer Reference Data.
    /// </summary>
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Last Transaction Flag.
    /// </summary>
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Merchant CIT Identification.
    /// </summary>
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    public IsoMax140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Merchant Reference Data.
    /// </summary>
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction131? OriginalTransaction { get; init; }

    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public ValueList<PaymentInstrumentType2Code> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Sale To Acquirer Data.
    /// </summary>
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    public IsoMax70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale To Issuer Data.
    /// </summary>
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    public IsoMax70Text? SaleToIssuerData { get; init; }

    /// <summary>
    /// Sale To POI Data.
    /// </summary>
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    public IsoMax70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Service Attribute.
    /// </summary>
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Transaction Capture.
    /// </summary>
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails53 TransactionDetails { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType16Code TransactionType { get; init; }
}
