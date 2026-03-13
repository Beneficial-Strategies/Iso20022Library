// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
/// </summary>
[IsoId("_8V3FELbhEeaqL_M7XFD7PQ")]
[DisplayName("Position Account")]
public partial record PositionAccount2
{
    #nullable enable
    
    /// <summary>
    /// Unique internal identification of the position account.
    /// </summary>
    [IsoId("_EmAWULbiEeaqL_M7XFD7PQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification165 Identification { get; init; } 
    
    /// <summary>
    /// Position in a financial instrument or set of financial instruments.
    /// </summary>
    [IsoId("_tRiU0bbiEeaqL_M7XFD7PQ")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    public ValueList<Position1> Position { get; init; } = [];
    // ID for the above is _tRiU0bbiEeaqL_M7XFD7PQ
    
    
    #nullable disable
    
}
