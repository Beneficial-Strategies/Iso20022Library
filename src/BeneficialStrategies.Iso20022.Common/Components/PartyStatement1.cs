// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_k24yhe5NEeCisYr99QEiWA_1451300165")]
[DisplayName("Party Statement")]
public partial record PartyStatement1
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_k3B8cO5NEeCisYr99QEiWA_1159342427")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; } 
    
    /// <summary>
    /// Provides information on the actual change occurred to a party.
    /// </summary>
    [IsoId("_k3B8ce5NEeCisYr99QEiWA_191976721")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public PartyReferenceDataChange1? Change { get; init; } 
    
    
    #nullable disable
    
}
