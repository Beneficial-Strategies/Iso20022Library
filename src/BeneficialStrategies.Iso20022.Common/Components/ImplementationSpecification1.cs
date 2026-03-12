// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the implementation specification to which the ISO 20022 message conforms.
/// </summary>
[IsoId("_6Pu8gMieEei73Ywzx0CAAg")]
[DisplayName("Implementation Specification")]
public partial record ImplementationSpecification1
{
    #nullable enable
    
    /// <summary>
    /// Name of the implementation specification registry in which the implementation specification of the ISO 20022 message is maintained.
    /// For example, &quot;MyStandards&quot;.
    /// </summary>
    [IsoId("_Dr2RoMifEei73Ywzx0CAAg")]
    [DisplayName("Registry")]
    [IsoXmlTag("Regy")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Registry { get; init; } 
    
    /// <summary>
    /// Identifier which unambiguously identifies, within the implementation specification registry, the implementation specification to which the ISO 20022 message is compliant. This can be done via a URN. It can also contain a version number or date.
    /// For instance, &quot;2018-01-01 – Version 2&quot; or &quot;urn:uuid:6e8bc430-9c3a-11d9-9669-0800200c9a66&quot;.
    /// </summary>
    [IsoId("_GKeQMMifEei73Ywzx0CAAg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public required IsoMax2048Text Identification { get; init; } 
    
    
    #nullable disable
    
}
