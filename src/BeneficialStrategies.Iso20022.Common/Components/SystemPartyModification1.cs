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
[IsoId("_kpB8sO5NEeCisYr99QEiWA_954294599")]
[DisplayName("System Party Modification")]
public partial record SystemPartyModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_kpB8se5NEeCisYr99QEiWA_-981777430")]
    [DisplayName("Scope Indication")]
    [IsoXmlTag("ScpIndctn")]
    public required DataModification1Code ScopeIndication { get; init; } 
    
    /// <summary>
    /// Specifies the set of elements to be modified for the party reference data.
    /// </summary>
    [IsoId("_kpB8su5NEeCisYr99QEiWA_-589754665")]
    [DisplayName("Requested Modification")]
    [IsoXmlTag("ReqdMod")]
    public required SystemPartyModification1Choice_ RequestedModification { get; init; } 
    
    
    #nullable disable
    
}
