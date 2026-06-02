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
[IsoId("_UbMbAZ_9EfC4Q_xhaK1hdQ")]
[DisplayName("Card Payment Transaction147")]
public record CardPaymentTransaction147
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_Ucc_RZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    public IsoTrueFalseIndicator? TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_Ucc_S5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_Ucc_UZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_Ucc_V5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    [IsoId("_Ucc_XZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Last Transaction Flag")]
    [IsoXmlTag("LastTxFlg")]
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_Ucc_Y5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Indicates whether the consent of the customer was explicitly obtained for a given service.
    /// </summary>
    [IsoId("_Ucc_aZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Specifies the card program proposed by a retailer to a cardholder.
    /// </summary>
    [IsoId("_Ucc_b5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// Specifies the card program actually selected by the cardholder.
    /// </summary>
    [IsoId("_Ucc_dZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public IsoMax35Text? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_Ucc_e5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Ucc_gZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_Ucc_h5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction149? OriginalTransaction { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_Ucc_jZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [IsoId("_Ucc_k5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result.
    /// </summary>
    [IsoId("_Ucc_mZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Override")]
    [IsoXmlTag("MrchntOvrrd")]
    public IsoTrueFalseIndicator? MerchantOverride { get; init; }

    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_Ucc_n5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public SimpleValueList<FailureReason3Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_Ucc_pZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_Ucc_q5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    public IsoMax140Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_Ucc_sZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_Ucc_t5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Identification, given by the Issuer, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_Ucc_vZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Issuer CIT Identification")]
    [IsoXmlTag("IssrCITId")]
    public IsoMax140Text? IssuerCITIdentification { get; init; }

    /// <summary>
    /// Identification, given by the merchant, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    [IsoId("_Ucc_w5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant CIT Identification")]
    [IsoXmlTag("MrchntCITId")]
    public IsoMax140Text? MerchantCITIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_Ucc_yZ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails54 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    [IsoId("_Ucc_z5_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult18? AuthorisationResult { get; init; }

    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    [IsoId("_Ucc_1Z_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    [IsoId("_Ucc_25_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount16? AccountFrom { get; init; }

    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    [IsoId("_Ucc_4Z_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount16? AccountTo { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_Ucc_55_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];

    /// <summary>
    /// Message from a merchant to be displayed on the cardholder bank statement.
    /// </summary>
    [IsoId("_9dKjkJ_9EfC4Q_xhaK1hdQ")]
    [DisplayName("Message From Merchant")]
    [IsoXmlTag("MsgFrMrchnt")]
    public ValueList<Action18> MessageFromMerchant { get; init; } = [];
}
