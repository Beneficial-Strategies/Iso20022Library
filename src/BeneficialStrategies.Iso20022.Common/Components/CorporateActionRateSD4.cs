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
[IsoId("_1XiiZTL3EeKU9IrkkToqcw_-291091942")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1XsTYDL3EeKU9IrkkToqcw_-404931008")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Corresponding rate of the security disbursed by CSD (for an example in US, DTC The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1XsTYTL3EeKU9IrkkToqcw_-1402003361")]
    [DisplayName("CSD Security Rate")]
    [IsoXmlTag("CSDSctyRate")]
    public RatioFormat13Choice_? CSDSecurityRate { get; init; } 
    
    
    #nullable disable
    
}
