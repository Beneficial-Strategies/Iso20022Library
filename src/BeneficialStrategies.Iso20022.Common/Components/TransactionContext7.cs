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
[IsoId("_4Dwf0YNuEeuHqfO1LgkE9Q")]
[DisplayName("Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionContext7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionContext7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionContext7( string reqMerchantCategoryCode )
    {
        MerchantCategoryCode = reqMerchantCategoryCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_GB4jbcpDEeuuJ571wNLKkA")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO18245MerchantCategoryCode MerchantCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string MerchantCategoryCode { get; init; } 
    #else
    public string MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_4Igc84NuEeuHqfO1LgkE9Q")]
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
    [IsoId("_4Igc9YNuEeuHqfO1LgkE9Q")]
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
    /// PIN pad is inoperative.
    /// Default: False - PIN pad is operative or not applicable.
    /// True: PIN pas is inoperative.
    /// </summary>
    [IsoId("_9x-gkbXnEeusf7oR9YukCg")]
    [DisplayName("PIN Pad Inoperative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINPadInprtv")]
    #endif
    [IsoXmlTag("PINPadInprtv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PINPadInoperative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PINPadInoperative { get; init; } 
    #else
    public System.String? PINPadInoperative { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate the PIN entry bypass.
    /// </summary>
    [IsoId("_wiS60DHIEeyTT91yHXSlSQ")]
    [DisplayName("PIN Entry Bypass Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINNtryBpssInd")]
    #endif
    [IsoXmlTag("PINNtryBpssInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PINEntryBypassIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PINEntryBypassIndicator { get; init; } 
    #else
    public System.String? PINEntryBypassIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    [IsoId("_4Igc94NuEeuHqfO1LgkE9Q")]
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
    /// A code that provides the reason of ICC fallback. 
    /// </summary>
    [IsoId("_GAoEoDHJEeyTT91yHXSlSQ")]
    [DisplayName("ICC Fallback Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCFllbckRsnCd")]
    #endif
    [IsoXmlTag("ICCFllbckRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ICCFallbackReason1Code? ICCFallbackReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ICCFallbackReason1Code? ICCFallbackReasonCode { get; init; } 
    #else
    public ICCFallbackReason1Code? ICCFallbackReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Other ICC fallback reason code defined at national or private level.
    /// </summary>
    [IsoId("_U5lAcDHKEeyTT91yHXSlSQ")]
    [DisplayName("Other ICC Fallback Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrICCFllbckRsnCd")]
    #endif
    [IsoXmlTag("OthrICCFllbckRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherICCFallbackReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherICCFallbackReasonCode { get; init; } 
    #else
    public System.String? OtherICCFallbackReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_4Igc-YNuEeuHqfO1LgkE9Q")]
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
    [IsoId("_4Igc-4NuEeuHqfO1LgkE9Q")]
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
    [IsoId("_4Igc_YNuEeuHqfO1LgkE9Q")]
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
    /// False: Delivery is not identified as deferred.
    /// Default: False.
    /// </summary>
    [IsoId("_4Igc_4NuEeuHqfO1LgkE9Q")]
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
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_kpZdYDHMEeyTT91yHXSlSQ")]
    [DisplayName("Partial Shipment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlShipmntInd")]
    #endif
    [IsoXmlTag("PrtlShipmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PartialShipmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialShipmentIndicator { get; init; } 
    #else
    public System.String? PartialShipmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_RbDCADKkEeyTT91yHXSlSQ")]
    [DisplayName("Delayed Charges Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DelydChrgsInd")]
    #endif
    [IsoXmlTag("DelydChrgsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DelayedChargesIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelayedChargesIndicator { get; init; } 
    #else
    public System.String? DelayedChargesIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented. 
    /// </summary>
    [IsoId("_aEHwoTKkEeyTT91yHXSlSQ")]
    [DisplayName("No Show Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoShowInd")]
    #endif
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NoShowIndicator { get; init; } 
    #else
    public System.String? NoShowIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_lvbhMDKkEeyTT91yHXSlSQ")]
    [DisplayName("Reauthorisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReauthstnInd")]
    #endif
    [IsoXmlTag("ReauthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReauthorisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReauthorisationIndicator { get; init; } 
    #else
    public System.String? ReauthorisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a resubmission. 
    /// </summary>
    [IsoId("_zLT3gDKkEeyTT91yHXSlSQ")]
    [DisplayName("Re Submission Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReSubmissnInd")]
    #endif
    [IsoXmlTag("ReSubmissnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReSubmissionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReSubmissionIndicator { get; init; } 
    #else
    public System.String? ReSubmissionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_4IgdAYNuEeuHqfO1LgkE9Q")]
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
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.  It does not indicate an outage in the issuer processing domain (including agents acting on behalf of the issuer).
    /// </summary>
    [IsoId("_zUMEQMVXEeuips4fuphvoQ")]
    [DisplayName("Authentication Outage Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnOutgInd")]
    #endif
    [IsoXmlTag("AuthntcnOutgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AuthenticationOutageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationOutageIndicator { get; init; } 
    #else
    public System.String? AuthenticationOutageIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_4IgdA4NuEeuHqfO1LgkE9Q")]
    [DisplayName("Card Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrgrmm")]
    #endif
    [IsoXmlTag("CardPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProgramme2? CardProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProgramme2? CardProgramme { get; init; } 
    #else
    public CardProgramme2? CardProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_oGRdgMVbEeuips4fuphvoQ")]
    [DisplayName("Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Jursdctn")]
    #endif
    [IsoXmlTag("Jursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Jurisdiction2? Jurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Jurisdiction2? Jurisdiction { get; init; } 
    #else
    public Jurisdiction2? Jurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_4IgdBYNuEeuHqfO1LgkE9Q")]
    [DisplayName("Settlement Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvc")]
    #endif
    [IsoXmlTag("SttlmSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementService3? SettlementService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementService3? SettlementService { get; init; } 
    #else
    public SettlementService3? SettlementService { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_4IgdB4NuEeuHqfO1LgkE9Q")]
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
    /// Further detailed information on the exchange rates that have been used in or are related to the transaction.
    /// </summary>
    [IsoId("_OieIkINvEeuHqfO1LgkE9Q")]
    [DisplayName("Exchange Rate Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateInf")]
    #endif
    [IsoXmlTag("XchgRateInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateInformation2? ExchangeRateInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateInformation2? ExchangeRateInformation { get; init; } 
    #else
    public ExchangeRateInformation2? ExchangeRateInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_4IgdCYNuEeuHqfO1LgkE9Q")]
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
    
    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_XMWaYMVYEeuips4fuphvoQ")]
    [DisplayName("Date Anticipated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAntcptd")]
    #endif
    [IsoXmlTag("DtAntcptd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateAnticipated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateAnticipated { get; init; } 
    #else
    public System.DateOnly? DateAnticipated { get; set; } 
    #endif
    
    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    [IsoId("_dHP2EMVZEeuips4fuphvoQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
