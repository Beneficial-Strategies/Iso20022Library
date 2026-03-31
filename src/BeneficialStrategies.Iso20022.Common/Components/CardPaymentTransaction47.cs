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
[IsoId("_GA0IUWmNEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction47
{
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_GOLO4WmNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionCapture { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_GOLO42mNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType5Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_GOLO5WmNEeS7iYydEtv3Ug")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType6Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_GOLO52mNEeS7iYydEtv3Ug")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_GOLO6WmNEeS7iYydEtv3Ug")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_GOLO62mNEeS7iYydEtv3Ug")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_GOLO7WmNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_GOLO72mNEeS7iYydEtv3Ug")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction37? OriginalTransaction { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_GOLO8WmNEeS7iYydEtv3Ug")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_GOLO82mNEeS7iYydEtv3Ug")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_GOLO9WmNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails24 TransactionDetails { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_GOLO92mNEeS7iYydEtv3Ug")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
