// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction during the authorisation.
/// </summary>
[IsoId("_ZWVB8R0gEeK5OKMB21JFBg")]
[DisplayName("Card Payment Transaction")]
public partial record CardPaymentTransaction11
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_ZiOv8R0gEeK5OKMB21JFBg")]
    [DisplayName("Transaction Capture")]
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionCapture { get; init; } 
    
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_ZiOv9R0gEeK5OKMB21JFBg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType4Code TransactionType { get; init; } 
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_ZiOv-R0gEeK5OKMB21JFBg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_ZiOv_R0gEeK5OKMB21JFBg")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_ZiOwAR0gEeK5OKMB21JFBg")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_ZiOwBR0gEeK5OKMB21JFBg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_ZiOwCR0gEeK5OKMB21JFBg")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction17? OriginalTransaction { get; init; } 
    
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_ZiOwDR0gEeK5OKMB21JFBg")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_ZiOwER0gEeK5OKMB21JFBg")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_ZiOwFR0gEeK5OKMB21JFBg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails1 TransactionDetails { get; init; } 
    
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_ZiOwGR0gEeK5OKMB21JFBg")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    
    
    #nullable disable
    
}
