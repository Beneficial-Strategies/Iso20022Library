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
[IsoId("_OOwPW3h4EeOF3uSOaAf1Lg")]
[DisplayName("Corporate Action Option SD")]
public record CorporateActionOptionSD9
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_OOwPXHh4EeOF3uSOaAf1Lg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_OOwPXXh4EeOF3uSOaAf1Lg")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; }

    /// <summary>
    /// Identifies whether the option will be processed as default by DTC (The Depository Trust Corporation) when no election is made.
    /// </summary>
    [IsoId("_OOwPYnh4EeOF3uSOaAf1Lg")]
    [DisplayName("DTC Default Option Flag")]
    [IsoXmlTag("DTCDfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCDefaultOptionFlag { get; init; }

    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_OOwPYXh4EeOF3uSOaAf1Lg")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy records. The number algorhithm is as follows: Department ID (1:1), Activity Type (2:3), Cusip Country Code (5:2), Cusip (7:9), Record Date (15:8), Payable Date (22:8), Sequence Number (29:3), RDP Issue Type (31:1).
    /// USAGE RULE: this sequence can be populated /extended to event details, option details or a movement, depending on sequence number coordinality to an event.
    /// </summary>
    [IsoId("_VOkhIXh4EeOF3uSOaAf1Lg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }
}
