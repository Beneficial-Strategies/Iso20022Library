// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification expressed as a proprietary type and narrative description.
/// </summary>
[IsoId("_7MgaQRHnEeG9eo4v8X6Ubw")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification39
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_7MqLRRHnEeG9eo4v8X6Ubw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
    [StringLength(maximumLength: 30 ,MinimumLength = 1)]
    public required IsoRestrictedFINMax30Text Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_7MqLSRHnEeG9eo4v8X6Ubw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoRestrictedFINMax8Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
