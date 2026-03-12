// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_WHL-ttp-Ed-ak6NoX_4Aeg_-856211268")]
[DisplayName("Restricted Identification")]
public partial record RestrictedIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_WHL-t9p-Ed-ak6NoX_4Aeg_-856211226")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedSMNDACodeText)]
    public required IsoRestrictedSMNDACodeText Identification { get; init; } 
    
    
    #nullable disable
    
}
