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
public partial record PaymentTransaction165
{
    /// <summary>
    /// Transaction Capture.
    /// </summary>
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    public TrueFalseIndicator? TransactionCapture { get; init; }

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
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType16Code TransactionType { get; init; }

    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Service Attribute.
    /// </summary>
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Last Transaction Flag.
    /// </summary>
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    public TrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public Min3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public Max35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction131? OriginalTransaction { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public Max35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Issuer Reference Data.
    /// </summary>
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public Max140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Issuer CIT Identification.
    /// </summary>
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    public Max140Text? IssuerCITIdentification { get; init; }

    /// <summary>
    /// Merchant CIT Identification.
    /// </summary>
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    public Max140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails53 TransactionDetails { get; init; }

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult18? AuthorisationResult { get; init; }

    /// <summary>
    /// Merchant Reference Data.
    /// </summary>
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public Max70Text? MerchantReferenceData { get; init; }

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
    /// Customer Consent.
    /// </summary>
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public TrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Card Programme Proposed.
    /// </summary>
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public ValueList<Max35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Card Programme Applied.
    /// </summary>
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public Max35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Sale To POI Data.
    /// </summary>
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    public Max70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Sale To Acquirer Data.
    /// </summary>
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    public Max70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale To Issuer Data.
    /// </summary>
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    public Max70Text? SaleToIssuerData { get; init; }

    /// <summary>
    /// Additional Transaction Data.
    /// </summary>
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public ValueList<Max70Text> AdditionalTransactionData { get; init; } = [];
}
