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
/// Transaction information in the cancellation advice.
/// </summary>
[IsoId("_TEgXpAEcEeCQm6a_G2yO_w_-1143929211")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction7( System.String reqMerchantCategoryCode,TransactionIdentifier1 reqTransactionIdentification,System.String reqTransactionSuccess,CardPaymentTransactionDetails7 reqTransactionDetails )
    {
        MerchantCategoryCode = reqMerchantCategoryCode;
        TransactionIdentification = reqTransactionIdentification;
        TransactionSuccess = reqTransactionSuccess;
        TransactionDetails = reqTransactionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_TEgXpQEcEeCQm6a_G2yO_w_1948759142")]
    [DisplayName("Transaction Capture")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCaptr")]
    #endif
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TransactionCapture { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionCapture { get; init; } 
    #else
    public System.String? TransactionCapture { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_TEgXpgEcEeCQm6a_G2yO_w_2017540007")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MerchantCategoryCode { get; init; } 
    #else
    public System.String MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TEgXpwEcEeCQm6a_G2yO_w_45111806")]
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
    [IsoId("_TEgXqAEcEeCQm6a_G2yO_w_1613731863")]
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
    [IsoId("_TEgXqQEcEeCQm6a_G2yO_w_1149740122")]
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
    [IsoId("_TEgXqgEcEeCQm6a_G2yO_w_-853085788")]
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
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_TEgXqwEcEeCQm6a_G2yO_w_-760327743")]
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
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_TEgXrAEcEeCQm6a_G2yO_w_42142930")]
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
    [IsoId("_TEgXrQEcEeCQm6a_G2yO_w_510950345")]
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
    [IsoId("_TEgXrgEcEeCQm6a_G2yO_w_76959935")]
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
    [IsoId("_TEgXrwEcEeCQm6a_G2yO_w_233425565")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransactionDetails7 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransactionDetails7 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransactionDetails7 TransactionDetails { get; init; } 
    #else
    public CardPaymentTransactionDetails7 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    [IsoId("_TEgXsAEcEeCQm6a_G2yO_w_461982943")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationResult2? AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult2? AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult2? AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_TEqIoAEcEeCQm6a_G2yO_w_1075398037")]
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
