// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_1ybjIeaMEei5aPS232E3Mw")]
[DisplayName("Corporate Action Option SD")]
public record CorporateActionOptionSD12
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_2Y9-seaMEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_2Y9-s-aMEei5aPS232E3Mw")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; }

    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_2Y9-u-aMEei5aPS232E3Mw")]
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; }

    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_2Y9-yeaMEei5aPS232E3Mw")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the oversubscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_2Y9-y-aMEei5aPS232E3Mw")]
    [DisplayName("Oversubscription Charge Flag")]
    [IsoXmlTag("OvrsbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OversubscriptionChargeFlag { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the protect charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_2Y9-zeaMEei5aPS232E3Mw")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the step-up charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_2Y9-z-aMEei5aPS232E3Mw")]
    [DisplayName("Step Up Charge Flag")]
    [IsoXmlTag("StepUpChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StepUpChargeFlag { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the subscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("_2Y9-0eaMEei5aPS232E3Mw")]
    [DisplayName("Subscription Charge Flag")]
    [IsoXmlTag("SbcptChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubscriptionChargeFlag { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_2Y9-0-aMEei5aPS232E3Mw")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Number of conditions for a given option that must be acknowledged upon submission of instruction for voluntary reorganisation  events.
    /// </summary>
    [IsoId("_XOQZsOaNEei5aPS232E3Mw")]
    [DisplayName("Number Of Conditions")]
    [IsoXmlTag("NbOfConds")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? NumberOfConditions { get; init; }

    /// <summary>
    /// Identification of the tax category as issuers, their agents, or tax authorities may require a breakdown of holders at a category level that have requested to receive a distribution at a favourable rate of tax.
    /// </summary>
    [IsoId("_hCxV0OaPEei5aPS232E3Mw")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory1> TaxCategory { get; init; } = [];
}
