// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date Period5.
/// </summary>
[IsoId("_2XduYSVIEe6EvsLBQ6cYtA")]
[DisplayName("Date Period5")]
public partial record DatePeriod5
{
    #nullable enable

    /// <summary>
    /// Current Value Date.
    /// </summary>
    [DisplayName("Current Value Date")]
    [IsoXmlTag("CurValDt")]
    public required IsoISODate CurrentValueDate { get; init; } 

    /// <summary>
    /// Requested Value Date.
    /// </summary>
    [DisplayName("Requested Value Date")]
    [IsoXmlTag("ReqdValDt")]
    public required IsoISODate RequestedValueDate { get; init; } 

    
    #nullable disable
    
}
