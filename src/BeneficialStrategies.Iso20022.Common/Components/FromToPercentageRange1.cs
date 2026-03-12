// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of percentage rates.
/// </summary>
[IsoId("_7_BRpaMgEeCJ6YNENx4h-w_873727815")]
[DisplayName("From To Percentage Range")]
public partial record FromToPercentageRange1
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRpqMgEeCJ6YNENx4h-w_-455806218")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required PercentageRangeBoundary1 From { get; init; } 
    
    /// <summary>
    /// Upper boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRp6MgEeCJ6YNENx4h-w_898182717")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required PercentageRangeBoundary1 To { get; init; } 
    
    
    #nullable disable
    
}
