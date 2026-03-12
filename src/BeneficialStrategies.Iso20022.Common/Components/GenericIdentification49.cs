// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
[IsoId("_m0KpUUhpEeOdL6nMHefDgg")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification49
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person or an institution for which no other specific identifier has been defined.
    /// </summary>
    [IsoId("_nDsTEUhpEeOdL6nMHefDgg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of identifier.
    /// </summary>
    [IsoId("_nDsTE0hpEeOdL6nMHefDgg")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IdentificationType { get; init; } 
    
    
    #nullable disable
    
}
