// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a percentage together with a period of time. For overlapping periods, the maximum of all applicable elements at a given date is the result.
/// </summary>
[IsoId("_OTgzMzg0-AOSNFX-8224502")]
[DisplayName("Percentage And Period")]
public partial record PercentageAndPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Covered percentage (max 100%).
    /// </summary>
    [IsoId("_OTgzMzg1-AOSNFX-8224502")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public required IsoPercentageBoundedRate Percentage { get; init; } 
    
    /// <summary>
    /// Start of period or immediate if not specified.
    /// </summary>
    [IsoId("_OTgzMzg2-AOSNFX-8224502")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// End of period or indefinite if not specified.
    /// </summary>
    [IsoId("_OThzMzg2-AOSNFX-8224502")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
