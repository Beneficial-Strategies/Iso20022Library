// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
[IsoId("_1kW2YjL3EeKU9IrkkToqcw_1154144563")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD6
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1kW2YzL3EeKU9IrkkToqcw_1801070650")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1kW2ZDL3EeKU9IrkkToqcw_-1766701812")]
    [DisplayName("Declared Security Rate")]
    [IsoXmlTag("DclrdSctyRate")]
    public CorporateActionRateSD6Choice_? DeclaredSecurityRate { get; init; } 
    
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_1kW2ZTL3EeKU9IrkkToqcw_1489361583")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_1kgnYDL3EeKU9IrkkToqcw_729716764")]
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD1Choice_? DeclaredFeeRate { get; init; } 
    
    
    #nullable disable
    
}
