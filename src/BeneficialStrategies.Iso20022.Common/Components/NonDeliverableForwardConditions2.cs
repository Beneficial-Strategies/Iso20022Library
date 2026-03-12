// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the opening and valuation conditions for the non deliverable forward.
/// </summary>
[IsoId("_dPfNQaZqEea16Jw8SEVrDQ")]
[DisplayName("Non Deliverable Forward Conditions")]
public partial record NonDeliverableForwardConditions2
{
    #nullable enable
    
    /// <summary>
    /// Provides the opening information associated with an NDF trade.
    /// </summary>
    [IsoId("_3xWiYKZqEea16Jw8SEVrDQ")]
    [DisplayName("Opening Conditions")]
    [IsoXmlTag("OpngConds")]
    public required OpeningConditions1 OpeningConditions { get; init; } 
    
    /// <summary>
    /// Provides the additional information for an NDF as supplied on a fixing instruction.
    /// </summary>
    [IsoId("_9vbDUKZqEea16Jw8SEVrDQ")]
    [DisplayName("Fixing Conditions")]
    [IsoXmlTag("FxgConds")]
    public FixingConditions1? FixingConditions { get; init; } 
    
    
    #nullable disable
    
}
