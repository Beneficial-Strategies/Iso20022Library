// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics for submitted derivatives per action type.
/// </summary>
[IsoId("_GQMZcIAsEeirUu_C8Wn_0Q")]
[DisplayName("Statistics Per Action Type")]
public partial record StatisticsPerActionType1
{
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives which have been reported.
    /// </summary>
    [IsoId("_PBU34IAsEeirUu_C8Wn_0Q")]
    [DisplayName("All")]
    [IsoXmlTag("All")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber All { get; init; } 
    
    /// <summary>
    /// Number of derivatives which have been reported as new.
    /// </summary>
    [IsoId("_QMXusIAsEeirUu_C8Wn_0Q")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber New { get; init; } 
    
    /// <summary>
    /// Number of derivatives which have been reported as modified.
    /// </summary>
    [IsoId("_Rh5-QIAsEeirUu_C8Wn_0Q")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber Modification { get; init; } 
    
    
    #nullable disable
    
}
