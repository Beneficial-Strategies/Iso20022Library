// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the kind of modification request for party reference data.
/// </summary>
[IsoId("_xtxKwYv-Eei289CGNqs21g")]
[DisplayName("System Party Modification")]
public partial record SystemPartyModification2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_x86aAYv-Eei289CGNqs21g")]
    [DisplayName("Scope Indication")]
    [IsoXmlTag("ScpIndctn")]
    public required DataModification1Code ScopeIndication { get; init; } 
    
    /// <summary>
    /// Specifies the set of elements to be modified for the party reference data.
    /// </summary>
    [IsoId("_x87BEYv-Eei289CGNqs21g")]
    [DisplayName("Requested Modification")]
    [IsoXmlTag("ReqdMod")]
    public required SystemPartyModification2Choice_ RequestedModification { get; init; } 
    
    
    #nullable disable
    
}
