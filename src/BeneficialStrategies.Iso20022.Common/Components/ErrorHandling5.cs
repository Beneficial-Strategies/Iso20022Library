// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the error resulting from the processing of a request.
/// </summary>
[IsoId("_Q2IvxXhdEeidzqjNEfehPg")]
[DisplayName("Error Handling")]
public partial record ErrorHandling5
{
    #nullable enable
    
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    [IsoId("_RA_78XhdEeidzqjNEfehPg")]
    [DisplayName("Error")]
    [IsoXmlTag("Err")]
    public required ErrorHandling3Choice_ Error { get; init; } 
    
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_RA_783hdEeidzqjNEfehPg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
