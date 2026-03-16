// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction143.
/// </summary>
[IsoId("_WW5cEZ-LEe-nbM0aSPcoiQ")]
[DisplayName("Card Payment Transaction143")]
public record CardPaymentTransaction143
{
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
    public AuthorisationResult19? AuthorisationResult { get; init; }

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
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Interchange Data.
    /// </summary>
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction138? OriginalTransaction { get; init; }

    /// <summary>
    /// Recipient Transaction Identification.
    /// </summary>
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    public IsoMax140Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Reversal.
    /// </summary>
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails50 TransactionDetails { get; init; }

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
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }
}
