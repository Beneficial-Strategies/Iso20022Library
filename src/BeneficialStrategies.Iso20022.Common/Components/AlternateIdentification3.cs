// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification of a security.
/// </summary>
[IsoId("_6bujcR5VEeWFEfGJQFSF5w")]
[DisplayName("Alternate Identification")]
public partial record AlternateIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_64vPkR5VEeWFEfGJQFSF5w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; } 
    
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    [IsoId("_64vPkx5VEeWFEfGJQFSF5w")]
    [DisplayName("Identification Source")]
    [IsoXmlTag("IdSrc")]
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    
    
    #nullable disable
    
}
