// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
[IsoId("_r8aHYVo6Ee23K4GXSpBSeg")]
[DisplayName("Time Period")]
public partial record TimePeriod3
{
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("_r90coVo6Ee23K4GXSpBSeg")]
    [DisplayName("From Time")]
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? FromTime { get; init; } 
    
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("_r90co1o6Ee23K4GXSpBSeg")]
    [DisplayName("To Time")]
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ToTime { get; init; } 
    
    
    #nullable disable
    
}
