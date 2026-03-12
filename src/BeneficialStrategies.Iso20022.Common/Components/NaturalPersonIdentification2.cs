// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a natural person through identification number, name and domicile.
/// </summary>
[IsoId("_izPYoS40Eeuxhbw_aW6haw")]
[DisplayName("Natural Person Identification")]
public partial record NaturalPersonIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the natural person.
    /// </summary>
    [IsoId("_jJtX4S40Eeuxhbw_aW6haw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification175 Identification { get; init; } 
    
    /// <summary>
    /// Indicates the name of the natural person.
    /// </summary>
    [IsoId("_jJtX4y40Eeuxhbw_aW6haw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? Name { get; init; } 
    
    /// <summary>
    /// Indicates the domicile of the natural person.
    /// </summary>
    [IsoId("_jJtX5S40Eeuxhbw_aW6haw")]
    [DisplayName("Domicile")]
    [IsoXmlTag("Dmcl")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? Domicile { get; init; } 
    
    
    #nullable disable
    
}
