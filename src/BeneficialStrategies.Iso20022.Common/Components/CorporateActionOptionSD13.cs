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
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_g_ekAQCAEeqouY-yI_q3qQ")]
[DisplayName("Corporate Action Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOptionSD13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_hS-HwQCAEeqouY-yI_q3qQ")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_hS-HwwCAEeqouY-yI_q3qQ")]
    [DisplayName("Extended Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOptnFeatrs")]
    #endif
    [IsoXmlTag("XtndedOptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #else
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_hS-HywCAEeqouY-yI_q3qQ")]
    [DisplayName("Default Option Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltOptnFlg")]
    #endif
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DefaultOptionFlag { get; init; } 
    #else
    public System.String? DefaultOptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_hS-H2QCAEeqouY-yI_q3qQ")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnlDvddSplmtryDataReqrdFlg")]
    #endif
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    #else
    public System.String? OptionalDividendSupplementaryDataRequiredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash debit for the oversubscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H2wCAEeqouY-yI_q3qQ")]
    [DisplayName("Oversubscription Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptChrgFlg")]
    #endif
    [IsoXmlTag("OvrsbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OversubscriptionChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OversubscriptionChargeFlag { get; init; } 
    #else
    public System.String? OversubscriptionChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash debit for the protect charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H3QCAEeqouY-yI_q3qQ")]
    [DisplayName("Protect Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctChrgFlg")]
    #endif
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectChargeFlag { get; init; } 
    #else
    public System.String? ProtectChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash debit for the step-up charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H3wCAEeqouY-yI_q3qQ")]
    [DisplayName("Step Up Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepUpChrgFlg")]
    #endif
    [IsoXmlTag("StepUpChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StepUpChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StepUpChargeFlag { get; init; } 
    #else
    public System.String? StepUpChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash debit for the subscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H4QCAEeqouY-yI_q3qQ")]
    [DisplayName("Subscription Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptChrgFlg")]
    #endif
    [IsoXmlTag("SbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SubscriptionChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubscriptionChargeFlag { get; init; } 
    #else
    public System.String? SubscriptionChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_hS-H4wCAEeqouY-yI_q3qQ")]
    [DisplayName("RDP Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RDPRefNb")]
    #endif
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDPReferenceNumber { get; init; } 
    #else
    public System.String? RDPReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of conditions for a given option that must be acknowledged upon submission of instruction for voluntary reorganisation  events.
    /// </summary>
    [IsoId("_hS-H5QCAEeqouY-yI_q3qQ")]
    [DisplayName("Number Of Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfConds")]
    #endif
    [IsoXmlTag("NbOfConds")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? NumberOfConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfConditions { get; init; } 
    #else
    public System.String? NumberOfConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the tax category as issuers, their agents, or tax authorities may require a breakdown of holders at a category level that have requested to receive a distribution at a favourable rate of tax.
    /// </summary>
    [IsoId("_hS-H5wCAEeqouY-yI_q3qQ")]
    [DisplayName("Tax Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCtgy")]
    #endif
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory1> TaxCategory { get; init; } = new ValueList<TaxCategory1>(){};
    
    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_j6MotQCAEeqouY-yI_q3qQ")]
    [DisplayName("Proration Rounding Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnRndgInd")]
    #endif
    [IsoXmlTag("PrratnRndgInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    #else
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. For example if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up.
    /// </summary>
    [IsoId("_j6MotgCAEeqouY-yI_q3qQ")]
    [DisplayName("Proration Fraction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnFrctn")]
    #endif
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProrationFraction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProrationFraction { get; init; } 
    #else
    public System.UInt64? ProrationFraction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
