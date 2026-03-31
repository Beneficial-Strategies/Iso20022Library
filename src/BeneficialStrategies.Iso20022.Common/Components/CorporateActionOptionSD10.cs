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
[IsoId("_ZhDAoaFaEeSK_vfd3NHBGg")]
[DisplayName("Corporate Action Option SD")]
public record CorporateActionOptionSD10
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_ZrA08aFaEeSK_vfd3NHBGg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_ZrA086FaEeSK_vfd3NHBGg")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; }

    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_ZrA0-6FaEeSK_vfd3NHBGg")]
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; }

    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_ZrA1CaFaEeSK_vfd3NHBGg")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_ZrA1C6FaEeSK_vfd3NHBGg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }
}
