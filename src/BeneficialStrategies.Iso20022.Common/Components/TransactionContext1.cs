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
/// Context of the card payment transaction.
/// </summary>
[IsoId("_N2aVEEbJEeeIjf8aP9KbJA")]
[DisplayName("Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionContext1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionContext1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionContext1( System.String reqMerchantCategoryCode )
    {
        MerchantCategoryCode = reqMerchantCategoryCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction.
    /// ISO 8583:87 bit 18, ISO 8583:93 bit 18 &amp; 26, ISO 8583:2003 bit 26
    /// ISO 18245
    /// </summary>
    [IsoId("_0UDfsEbJEeeIjf8aP9KbJA")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4NumericText MerchantCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MerchantCategoryCode { get; init; } 
    #else
    public System.String MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_t_9bABqbEeqH1IQNpbVpEw")]
    [DisplayName("Merchant Category Specific Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgySpcfcData")]
    #endif
    [IsoXmlTag("MrchntCtgySpcfcData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MerchantCategorySpecificData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategorySpecificData { get; init; } 
    #else
    public System.String? MerchantCategorySpecificData { get; set; } 
    #endif
    
    /// <summary>
    /// Notifies the express consent of the customer for a given service (used in DCC, funds transfers, money lending, etc.).
    /// True: Explicit customer consent obtained
    /// False: Implicit customer consent obtained
    /// </summary>
    [IsoId("_vvfW4BYjEeiXa46FI4OtcQ")]
    [DisplayName("Customer Consent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrCnsnt")]
    #endif
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerConsent { get; init; } 
    #else
    public System.String? CustomerConsent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a chip data fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_BUOY8BYkEeiXa46FI4OtcQ")]
    [DisplayName("ICC Fallback Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCFllbckInd")]
    #endif
    [IsoXmlTag("ICCFllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ICCFallbackIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ICCFallbackIndicator { get; init; } 
    #else
    public System.String? ICCFallbackIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_8YagYZQqEemrTL7utsGcSA")]
    [DisplayName("Magnetic Stripe Fallback Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MgntcStrpFllbckInd")]
    #endif
    [IsoXmlTag("MgntcStrpFllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MagneticStripeFallbackIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MagneticStripeFallbackIndicator { get; init; } 
    #else
    public System.String? MagneticStripeFallbackIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// True: Transaction was presented late
    /// False: Transaction was not presented late
    /// Default: False
    /// </summary>
    [IsoId("_8sLIYdIjEeirx-13kKhDlQ")]
    [DisplayName("Late Presentment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatePresntmntInd")]
    #endif
    [IsoXmlTag("LatePresntmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LatePresentmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LatePresentmentIndicator { get; init; } 
    #else
    public System.String? LatePresentmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance. 
    /// </summary>
    [IsoId("_s_a0UP_FEeiAhqX-7sOgTw")]
    [DisplayName("Final Authorisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlAuthstnInd")]
    #endif
    [IsoXmlTag("FnlAuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FinalAuthorisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinalAuthorisationIndicator { get; init; } 
    #else
    public System.String? FinalAuthorisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deffered.
    /// Default: False.
    /// </summary>
    [IsoId("_CroeoGzeEemD24gVaMSpeA")]
    [DisplayName("Deferred Delivery Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfrrdDlvryInd")]
    #endif
    [IsoXmlTag("DfrrdDlvryInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeferredDeliveryIndicator { get; init; } 
    #else
    public System.String? DeferredDeliveryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_pESJoWzgEemD24gVaMSpeA")]
    [DisplayName("Transaction Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInitr")]
    #endif
    [IsoXmlTag("TxInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    #else
    public TransactionInitiator1Code? TransactionInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_r1W_oEbKEeeIjf8aP9KbJA")]
    [DisplayName("Card Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrgrmm")]
    #endif
    [IsoXmlTag("CardPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProgramme1? CardProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProgramme1? CardProgramme { get; init; } 
    #else
    public CardProgramme1? CardProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_60-ZkEbKEeeIjf8aP9KbJA")]
    [DisplayName("Settlement Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvc")]
    #endif
    [IsoXmlTag("SttlmSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementService1? SettlementService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementService1? SettlementService { get; init; } 
    #else
    public SettlementService1? SettlementService { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_EvvZkEbLEeeIjf8aP9KbJA")]
    [DisplayName("Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcncltn")]
    #endif
    [IsoXmlTag("Rcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reconciliation3? Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reconciliation3? Reconciliation { get; init; } 
    #else
    public Reconciliation3? Reconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_3fCtoEbMEeeIjf8aP9KbJA")]
    [DisplayName("Capture Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CaptrDt")]
    #endif
    [IsoXmlTag("CaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CaptureDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CaptureDate { get; init; } 
    #else
    public System.DateOnly? CaptureDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
