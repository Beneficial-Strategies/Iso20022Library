// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate information.
/// </summary>
[IsoId("_99Ei5nltEeG7BsjMvd1mEw_171384620")]
[DisplayName("Percentage")]
public partial record Percentage1
{
    #nullable enable
    
    /// <summary>
    /// Percentage of an amount.
    /// </summary>
    [IsoId("_99Ei53ltEeG7BsjMvd1mEw_-1531427799")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    /// <summary>
    /// Indication of what the percentage is relative to.
    /// </summary>
    [IsoId("_99Ei6HltEeG7BsjMvd1mEw_880195488")]
    [DisplayName("Relative To")]
    [IsoXmlTag("RltvTo")]
    public required ExternalRelativeTo1Code RelativeTo { get; init; } 
    
    
    #nullable disable
    
}
