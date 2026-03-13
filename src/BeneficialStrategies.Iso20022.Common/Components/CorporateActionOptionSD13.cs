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
[IsoId("_g_ekAQCAEeqouY-yI_q3qQ")]
[DisplayName("Corporate Action Option SD")]
public partial record CorporateActionOptionSD13
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_hS-HwQCAEeqouY-yI_q3qQ")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_hS-HwwCAEeqouY-yI_q3qQ")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    
    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_hS-HywCAEeqouY-yI_q3qQ")]
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_hS-H2QCAEeqouY-yI_q3qQ")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the oversubscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H2wCAEeqouY-yI_q3qQ")]
    [DisplayName("Oversubscription Charge Flag")]
    [IsoXmlTag("OvrsbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OversubscriptionChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the protect charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H3QCAEeqouY-yI_q3qQ")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the step-up charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H3wCAEeqouY-yI_q3qQ")]
    [DisplayName("Step Up Charge Flag")]
    [IsoXmlTag("StepUpChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StepUpChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash debit for the subscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_hS-H4QCAEeqouY-yI_q3qQ")]
    [DisplayName("Subscription Charge Flag")]
    [IsoXmlTag("SbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubscriptionChargeFlag { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_hS-H4wCAEeqouY-yI_q3qQ")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    /// <summary>
    /// Number of conditions for a given option that must be acknowledged upon submission of instruction for voluntary reorganisation  events.
    /// </summary>
    [IsoId("_hS-H5QCAEeqouY-yI_q3qQ")]
    [DisplayName("Number Of Conditions")]
    [IsoXmlTag("NbOfConds")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? NumberOfConditions { get; init; } 
    
    /// <summary>
    /// Identification of the tax category as issuers, their agents, or tax authorities may require a breakdown of holders at a category level that have requested to receive a distribution at a favourable rate of tax.
    /// </summary>
    [IsoId("_hS-H5wCAEeqouY-yI_q3qQ")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory1> TaxCategory { get; init; } = [];
    
    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_j6MotQCAEeqouY-yI_q3qQ")]
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    
    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. For example if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up.
    /// </summary>
    [IsoId("_j6MotgCAEeqouY-yI_q3qQ")]
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProrationFraction { get; init; } 
    
    
    #nullable disable
    
}
