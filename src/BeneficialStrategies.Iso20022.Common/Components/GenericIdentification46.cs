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
[IsoId("_ZMvD8Rc0EeK5g-3oYI0_9Q")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification46
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, national registration identification number.
    /// </summary>
    [IsoId("_ZnjXsRc0EeK5g-3oYI0_9Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    [IsoId("_pSIaMBc0EeK5g-3oYI0_9Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OtherIdentification1Choice_ Type { get; init; } 
    
    
    #nullable disable
    
}
