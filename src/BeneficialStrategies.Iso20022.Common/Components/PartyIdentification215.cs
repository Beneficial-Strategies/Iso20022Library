// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_VN2d9zqcEemL_ewJY9QP1g")]
[DisplayName("Party Identification")]
public partial record PartyIdentification215
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_4I5rkDqcEemL_ewJY9QP1g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_W9qZQDqdEemL_ewJY9QP1g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification195Choice_ Identification { get; init; } 
    
    
    #nullable disable
    
}
