// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional information about the fuel location, such as hours of operation and Interstate Access/Exit Number, etc.
/// </summary>
[IsoId("_XRiBY_i7EeiJaN6-Lf-c_w")]
[DisplayName("Local Amenity")]
public partial record LocalAmenity1
{
    #nullable enable
    
    /// <summary>
    /// Type of additional service available.
    /// </summary>
    [IsoId("_XRiBZfi7EeiJaN6-Lf-c_w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LocationAmenity1Code Type { get; init; } 
    
    /// <summary>
    /// Other additional service available at the location. 
    /// </summary>
    [IsoId("_XRiBZPi7EeiJaN6-Lf-c_w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Indicates whether or not a specific type of amenity is available at this location.
    /// </summary>
    [IsoId("_W3hCEPi_EeiJaN6-Lf-c_w")]
    [DisplayName("Available Indicator")]
    [IsoXmlTag("AvlblInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AvailableIndicator { get; init; } 
    
    
    #nullable disable
    
}
