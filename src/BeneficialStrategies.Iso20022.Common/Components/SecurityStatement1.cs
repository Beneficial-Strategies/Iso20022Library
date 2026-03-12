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
[IsoId("_k2SVlO5NEeCisYr99QEiWA_-304075371")]
[DisplayName("Security Statement")]
public partial record SecurityStatement1
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_k2cGkO5NEeCisYr99QEiWA_1259627499")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; } 
    
    /// <summary>
    /// Provides information on the actual change occurred to a financial instrument.
    /// </summary>
    [IsoId("_k2cGke5NEeCisYr99QEiWA_-950079708")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public SecuritiesReferenceDataChange1? Change { get; init; } 
    
    
    #nullable disable
    
}
