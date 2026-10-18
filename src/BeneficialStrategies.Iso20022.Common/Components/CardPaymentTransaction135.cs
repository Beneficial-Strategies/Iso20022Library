// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction135.
/// </summary>
[IsoId("_9pHC0ZIvEe6RsYhlPIxpVw")]
[DisplayName("Card Payment Transaction135")]
public record CardPaymentTransaction135
{
    /// <summary>
    /// Account From.
    /// </summary>
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount16? AccountFrom { get; init; }

    /// <summary>
    /// Account To.
    /// </summary>
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount16? AccountTo { get; init; }

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
    public ValueList<Max70Text> AdditionalTransactionData { get; init; } = [];

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
    public Max35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Card Programme Proposed.
    /// </summary>
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public ValueList<Max35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Customer Consent.
    /// </summary>
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public TrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Failure Reason.
    /// </summary>
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public ValueList<FailureReason3Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Initiator Transaction Identification.
    /// </summary>
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    public Max35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Interchange Data.
    /// </summary>
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    public Max140Text? InterchangeData { get; init; }

    /// <summary>
    /// Issuer CIT Identification.
    /// </summary>
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    public Max140Text? IssuerCITIdentification { get; init; }

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
    /// Merchant CIT Identification.
    /// </summary>
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    public Max140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Merchant Override.
    /// </summary>
    [DisplayName("Merchant Override")]
    [IsoXmlTag("MrchntOvrrd")]
    public TrueFalseIndicator? MerchantOverride { get; init; }

    /// <summary>
    /// Merchant Reference Data.
    /// </summary>
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public Max70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction122? OriginalTransaction { get; init; }

    /// <summary>
    /// Recipient Transaction Identification.
    /// </summary>
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    public Max140Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public Max35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Reversal.
    /// </summary>
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public TrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public Max35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Service Attribute.
    /// </summary>
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Transaction Capture.
    /// </summary>
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    public TrueFalseIndicator? TransactionCapture { get; init; }

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
    /// Transaction Success.
    /// </summary>
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    public required TrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }
}
