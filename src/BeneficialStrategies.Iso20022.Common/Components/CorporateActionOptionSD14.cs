// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_eEjNwQ7sEeuZI5Sr_GAcuA")]
[DisplayName("Corporate Action Option SD")]
public partial record CorporateActionOptionSD14
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_eZ-rMQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in the standard ISO message.
    /// </summary>
    [IsoId("_eZ-rMw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    
    /// <summary>
    /// Indicates whether the option is declared as default by the issuer/offeror, and will be treated as default by the issuer/offeror if no elections is made.
    /// </summary>
    [IsoId("_eZ-rOw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 corporate action instruction (CAIN) message for this event.
    /// </summary>
    [IsoId("_eZ-rSQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the oversubscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_eZ-rSw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Oversubscription Charge Flag")]
    [IsoXmlTag("OvrsbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OversubscriptionChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the protect charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_eZ-rTQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the step-up charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_eZ-rTw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Step Up Charge Flag")]
    [IsoXmlTag("StepUpChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StepUpChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the subscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_eZ-rUQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Subscription Charge Flag")]
    [IsoXmlTag("SbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubscriptionChargeFlag { get; init; } 
    
    /// <summary>
    /// Determines the disposition of odd lot quantities resulting from proration. Depending on the event, if the remaining quantity (instructed quantity – accepted prorated quantity) is an odd lot, it may be added to the accepted instruction quantity. 
    /// </summary>
    [IsoId("_s6LlQA7sEeuZI5Sr_GAcuA")]
    [DisplayName("Back End Odd Lot Quantity Flag")]
    [IsoXmlTag("BckEndOddLotQtyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BackEndOddLotQuantityFlag { get; init; } 
    
    /// <summary>
    /// Identifies whether the exemption is in effect. Some offers stipulate that instructions submitted on odd lot positions will be exempted from any proration if submitted in full. 
    /// </summary>
    [IsoId("_KMmWcA7tEeuZI5Sr_GAcuA")]
    [DisplayName("Front End Odd Lot Quantity Flag")]
    [IsoXmlTag("FrntEndOddLotQtyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FrontEndOddLotQuantityFlag { get; init; } 
    
    /// <summary>
    /// Indicates, whether an option for certain events may have a full condition indicator, meaning that either the conditional quantity must be instructed in full (equal to the instructed quantity) or zero must be instructed.  
    /// </summary>
    [IsoId("_FExrkA7uEeuZI5Sr_GAcuA")]
    [DisplayName("Full Condition Flag")]
    [IsoXmlTag("FullCondFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FullConditionFlag { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_eZ-rUw7sEeuZI5Sr_GAcuA")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    /// <summary>
    /// Number of conditions for a given option that must be acknowledged upon submission of instruction for voluntary reorganisation events.
    /// </summary>
    [IsoId("_eZ-rVQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Number Of Conditions")]
    [IsoXmlTag("NbOfConds")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? NumberOfConditions { get; init; } 
    
    /// <summary>
    /// Identification of the tax category as issuers, their agents, or tax authorities may require a breakdown of holders at a category level that have requested to receive a distribution at a favourable rate of tax.
    /// </summary>
    [IsoId("_eZ-rVw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory1> TaxCategory { get; init; } = new ValueList<TaxCategory1>(){};
    
    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_eZ-rWQ7sEeuZI5Sr_GAcuA")]
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    
    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. For example if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up.
    /// </summary>
    [IsoId("_eZ-rWw7sEeuZI5Sr_GAcuA")]
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProrationFraction { get; init; } 
    
    /// <summary>
    /// Participation in the event requires that certain conditions be met by the holder for certain voluntary options.
    /// </summary>
    [IsoId("_tMDJoA7yEeuZI5Sr_GAcuA")]
    [DisplayName("Option Conditions")]
    [IsoXmlTag("OptnConds")]
    [MinLength(0)]
    [MaxLength(6)]
    public ValueList<OptionConditions1> OptionConditions { get; init; } = new ValueList<OptionConditions1>(){};
    
    
    #nullable disable
    
}
