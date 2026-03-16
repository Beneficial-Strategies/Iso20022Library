// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option SD15.
/// </summary>
[IsoId("_RpGNIXG0Ee6S2Llv74R19w")]
[DisplayName("Corporate Action Option SD15")]
public record CorporateActionOptionSD15
{
    /// <summary>
    /// Agent Accept Reject Indicator.
    /// </summary>
    [DisplayName("Agent Accept Reject Indicator")]
    [IsoXmlTag("AgtAccptRjctInd")]
    public AgentAcceptReject1Code? AgentAcceptRejectIndicator { get; init; }

    /// <summary>
    /// Back End Odd Lot Quantity Flag.
    /// </summary>
    [DisplayName("Back End Odd Lot Quantity Flag")]
    [IsoXmlTag("BckEndOddLotQtyFlg")]
    public IsoYesNoIndicator? BackEndOddLotQuantityFlag { get; init; }

    /// <summary>
    /// Default Option Flag.
    /// </summary>
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; }

    /// <summary>
    /// Extended Option Features.
    /// </summary>
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; }

    /// <summary>
    /// Front End Odd Lot Quantity Flag.
    /// </summary>
    [DisplayName("Front End Odd Lot Quantity Flag")]
    [IsoXmlTag("FrntEndOddLotQtyFlg")]
    public IsoYesNoIndicator? FrontEndOddLotQuantityFlag { get; init; }

    /// <summary>
    /// Full Condition Flag.
    /// </summary>
    [DisplayName("Full Condition Flag")]
    [IsoXmlTag("FullCondFlg")]
    public IsoYesNoIndicator? FullConditionFlag { get; init; }

    /// <summary>
    /// Number Of Conditions.
    /// </summary>
    [DisplayName("Number Of Conditions")]
    [IsoXmlTag("NbOfConds")]
    public IsoMax2NumericText? NumberOfConditions { get; init; }

    /// <summary>
    /// Optional Dividend Supplementary Data Required Flag.
    /// </summary>
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; }

    /// <summary>
    /// Option Conditions.
    /// </summary>
    [DisplayName("Option Conditions")]
    [IsoXmlTag("OptnConds")]
    public OptionConditions1? OptionConditions { get; init; }

    /// <summary>
    /// Oversubscription Charge Flag.
    /// </summary>
    [DisplayName("Oversubscription Charge Flag")]
    [IsoXmlTag("OvrsbcptChrgFlg")]
    public IsoYesNoIndicator? OversubscriptionChargeFlag { get; init; }

    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Proration Fraction.
    /// </summary>
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    public IsoDecimalNumber? ProrationFraction { get; init; }

    /// <summary>
    /// Proration Rounding Indicator.
    /// </summary>
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; }

    /// <summary>
    /// Protect Charge Flag.
    /// </summary>
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; }

    /// <summary>
    /// RDP Reference Number.
    /// </summary>
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Step Up Charge Flag.
    /// </summary>
    [DisplayName("Step Up Charge Flag")]
    [IsoXmlTag("StepUpChrgFlg")]
    public IsoYesNoIndicator? StepUpChargeFlag { get; init; }

    /// <summary>
    /// Subscription Charge Flag.
    /// </summary>
    [DisplayName("Subscription Charge Flag")]
    [IsoXmlTag("SbcptChrgFlg")]
    public IsoYesNoIndicator? SubscriptionChargeFlag { get; init; }

    /// <summary>
    /// Tax Category.
    /// </summary>
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    public TaxCategory1? TaxCategory { get; init; }
}
