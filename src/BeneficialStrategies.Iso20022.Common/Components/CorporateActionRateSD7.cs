// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
[IsoId("_1kgnYTL3EeKU9IrkkToqcw_-1578187294")]
[DisplayName("Corporate Action Rate SD")]
public record CorporateActionRateSD7
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1kgnYjL3EeKU9IrkkToqcw_-753142535")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Corresponding rate of the security disbursed by CSD (for an example in US, DTC The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1kgnYzL3EeKU9IrkkToqcw_1661519121")]
    [DisplayName("CSD Security Rate")]
    [IsoXmlTag("CSDSctyRate")]
    public CorporateActionRateSD6Choice_? CSDSecurityRate { get; init; }

    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_1kgnZDL3EeKU9IrkkToqcw_1261231895")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; }

    /// <summary>
    /// Rate at which a fee will be charged to a DTC (The Depository Trust Corporation) participant.
    /// </summary>
    [IsoId("_1kgnZTL3EeKU9IrkkToqcw_-358551397")]
    [DisplayName("DTC Fee Rate")]
    [IsoXmlTag("DTCFeeRate")]
    public PriceFormatSD1Choice_? DTCFeeRate { get; init; }
}
