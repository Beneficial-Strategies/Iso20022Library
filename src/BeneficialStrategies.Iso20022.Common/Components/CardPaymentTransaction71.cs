// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction to authorise.
/// </summary>
[IsoId("_aJ-uUa2QEeawR4FMacHsRQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction71
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_aU490a2QEeawR4FMacHsRQ")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_aU49062QEeawR4FMacHsRQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType5Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_aU491a2QEeawR4FMacHsRQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_aU49162QEeawR4FMacHsRQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_aU492a2QEeawR4FMacHsRQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    [IsoId("_HIqYELL3EeaRnrUTla0j3A")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public SimpleValueList<IsoTrueFalseIndicator> CustomerConsent { get; init; } = [];

    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    [IsoId("_OCOQ4LL3EeaRnrUTla0j3A")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public SimpleValueList<IsoMax35Text> CardProgrammeProposed { get; init; } = [];

    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    [IsoId("_V2oBULL3EeaRnrUTla0j3A")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public SimpleValueList<IsoMax35Text> CardProgrammeApplied { get; init; } = [];

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_aU49262QEeawR4FMacHsRQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_aU493a2QEeawR4FMacHsRQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_aU49362QEeawR4FMacHsRQ")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction52? OriginalTransaction { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_aU494a2QEeawR4FMacHsRQ")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_aU49462QEeawR4FMacHsRQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_aU495a2QEeawR4FMacHsRQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails39 TransactionDetails { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_aU49562QEeawR4FMacHsRQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
