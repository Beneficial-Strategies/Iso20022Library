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
/// Context of the card payment transaction
/// </summary>
[IsoId("_27QfUcVcEeuips4fuphvoQ")]
[DisplayName("Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionContext9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_3AMCocVcEeuips4fuphvoQ")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MerchantCategoryCode { get; init; } 
    #else
    public string? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_7m2H4cpCEeuuJ571wNLKkA")]
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
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deffered.
    /// Default: False.
    /// </summary>
    [IsoId("_3AMCo8VcEeuips4fuphvoQ")]
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
    [IsoId("_7Lw3ETHMEeyTT91yHXSlSQ")]
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
    [IsoId("_E1k50TKlEeyTT91yHXSlSQ")]
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
    [IsoId("_F3UqsTKlEeyTT91yHXSlSQ")]
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
    [IsoId("_APPA0TKlEeyTT91yHXSlSQ")]
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
    [IsoId("_CQ6ksTKlEeyTT91yHXSlSQ")]
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
    [IsoId("_3AMCpcVcEeuips4fuphvoQ")]
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
    [IsoId("_CtpsWsV-Eeua2vd9tJAtHg")]
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
    [IsoId("_3AMCp8VcEeuips4fuphvoQ")]
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
    [IsoId("_BMrEwMVdEeuips4fuphvoQ")]
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
    [IsoId("_3AMCqcVcEeuips4fuphvoQ")]
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
    [IsoId("_3AMCq8VcEeuips4fuphvoQ")]
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
    [IsoId("_3AMCrcVcEeuips4fuphvoQ")]
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
    [IsoId("_EHJ15MV-Eeua2vd9tJAtHg")]
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
    [IsoId("_FjiUUcV-Eeua2vd9tJAtHg")]
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
