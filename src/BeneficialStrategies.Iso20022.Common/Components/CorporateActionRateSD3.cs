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
[IsoId("_1gfDATL3EeKU9IrkkToqcw_9605832")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1gfDAjL3EeKU9IrkkToqcw_-987466521")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1gfDAzL3EeKU9IrkkToqcw_-1290523036")]
    [DisplayName("Declared Security Rate")]
    [IsoXmlTag("DclrdSctyRate")]
    public RatioFormat13Choice_? DeclaredSecurityRate { get; init; } 
    
    
    #nullable disable
    
}
