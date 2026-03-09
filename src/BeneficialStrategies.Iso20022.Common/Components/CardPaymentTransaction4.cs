// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the batch capture.
/// </summary>
[IsoId("_TFsqegEcEeCQm6a_G2yO_w_-106788857")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction4( TransactionIdentifier1 reqTransactionIdentification,System.String reqTransactionSuccess,CardPaymentTransactionDetails4 reqTransactionDetails )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionSuccess = reqTransactionSuccess;
        TransactionDetails = reqTransactionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_TFsqewEcEeCQm6a_G2yO_w_-741820703")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType1Code? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType1Code? TransactionType { get; init; } 
    #else
    public CardPaymentServiceType1Code? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_TFsqfAEcEeCQm6a_G2yO_w_-183203476")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType2Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_TFsqfQEcEeCQm6a_G2yO_w_756680186")]
    [DisplayName("Service Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcAttr")]
    #endif
    [IsoXmlTag("SvcAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    #else
    public CardPaymentServiceType3Code? ServiceAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_TFsqfgEcEeCQm6a_G2yO_w_336199635")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategoryCode { get; init; } 
    #else
    public System.String? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TFsqfwEcEeCQm6a_G2yO_w_-1949725820")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_TF2bcAEcEeCQm6a_G2yO_w_-1495638551")]
    [DisplayName("Original Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTx")]
    #endif
    [IsoXmlTag("OrgnlTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction8? OriginalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction8? OriginalTransaction { get; init; } 
    #else
    public CardPaymentTransaction8? OriginalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_TF2bcQEcEeCQm6a_G2yO_w_-1413770249")]
    [DisplayName("Transaction Success")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSucss")]
    #endif
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionSuccess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionSuccess { get; init; } 
    #else
    public System.String TransactionSuccess { get; set; } 
    #endif
    
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [IsoId("_TF2bcgEcEeCQm6a_G2yO_w_579282451")]
    [DisplayName("Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsl")]
    #endif
    [IsoXmlTag("Rvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reversal { get; init; } 
    #else
    public System.String? Reversal { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    [IsoId("_TF2bcwEcEeCQm6a_G2yO_w_-2020589262")]
    [DisplayName("Merchant Override")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntOvrrd")]
    #endif
    [IsoXmlTag("MrchntOvrrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MerchantOverride { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantOverride { get; init; } 
    #else
    public System.String? MerchantOverride { get; set; } 
    #endif
    
    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_TF2bdAEcEeCQm6a_G2yO_w_1944434253")]
    [DisplayName("Failure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FailrRsn")]
    #endif
    [IsoXmlTag("FailrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FailureReason1Code? FailureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailureReason1Code? FailureReason { get; init; } 
    #else
    public FailureReason1Code? FailureReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_TF2bdQEcEeCQm6a_G2yO_w_-2052847941")]
    [DisplayName("Initiator Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitrTxId")]
    #endif
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InitiatorTransactionIdentification { get; init; } 
    #else
    public System.String? InitiatorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_TF2bdgEcEeCQm6a_G2yO_w_1919917234")]
    [DisplayName("Recipient Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptTxId")]
    #endif
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RecipientTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecipientTransactionIdentification { get; init; } 
    #else
    public System.String? RecipientTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_TF2bdwEcEeCQm6a_G2yO_w_-1932061570")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationIdentification { get; init; } 
    #else
    public System.String? ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_TF2beAEcEeCQm6a_G2yO_w_-1638072282")]
    [DisplayName("Interchange Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrchngData")]
    #endif
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InterchangeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterchangeData { get; init; } 
    #else
    public System.String? InterchangeData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_TF2beQEcEeCQm6a_G2yO_w_892473672")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransactionDetails4 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransactionDetails4 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransactionDetails4 TransactionDetails { get; init; } 
    #else
    public CardPaymentTransactionDetails4 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the authorisation request, and actions to perform.
    /// </summary>
    [IsoId("_TF2begEcEeCQm6a_G2yO_w_499764305")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationResult1? AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult1? AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult1? AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_TF2bewEcEeCQm6a_G2yO_w_1260529458")]
    [DisplayName("Transaction Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxVrfctnRslt")]
    #endif
    [IsoXmlTag("TxVrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult1? TransactionVerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult1? TransactionVerificationResult { get; init; } 
    #else
    public TransactionVerificationResult1? TransactionVerificationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_TF2bfAEcEeCQm6a_G2yO_w_-635588334")]
    [DisplayName("Additional Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxData")]
    #endif
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionData { get; init; } 
    #else
    public System.String? AdditionalTransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
