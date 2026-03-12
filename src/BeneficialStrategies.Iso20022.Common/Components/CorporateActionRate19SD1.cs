// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to capture new to old ratio with extra digits.
/// </summary>
[IsoId("_gCCBwHcYEeGgn5GmpWx6yw")]
[DisplayName("Corporate Action Rate 19 SD")]
public partial record CorporateActionRate19SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_1TV0hXceEeGgn5GmpWx6yw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Ratio expressed as a quotient of high precision quantities.
    /// </summary>
    [IsoId("_igkj8HccEeGgn5GmpWx6yw")]
    [DisplayName("Long Quantity To Quantity")]
    [IsoXmlTag("LngQtyToQty")]
    public required LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; init; } 
    
    
    #nullable disable
    
}
