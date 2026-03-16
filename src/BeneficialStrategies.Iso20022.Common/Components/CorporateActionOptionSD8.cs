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
[IsoId("_St-LoV2oEeOb__BffbPEig")]
[DisplayName("Corporate Action Option SD")]
public record CorporateActionOptionSD8
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_TITXMV2oEeOb__BffbPEig")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_TITXM12oEeOb__BffbPEig")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; }

    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_TITXO12oEeOb__BffbPEig")]
    [DisplayName("Default Option Flag")]
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DefaultOptionFlag { get; init; }

    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_TITXSV2oEeOb__BffbPEig")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy records. The number algorhithm is as follows: Department ID (1:1), Activity Type (2:3), Cusip Country Code (5:2), Cusip (7:9), Record Date (15:8), Payable Date (22:8), Sequence Number (29:3), RDP Issue Type (31:1).
    /// USAGE RULE: this sequence can be populated /extended to event details, option details or a movement, depending on sequence number coordinality to an event.
    /// </summary>
    [IsoId("_C-YHQXh4EeOF3uSOaAf1Lg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }
}
