// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Adjustment Request1.
/// </summary>
[IsoId("_hWdscRc0Ee6CaqQSK5g6qw")]
[DisplayName("Adjustment Request1")]
public partial record AdjustmentRequest1
{
    #nullable enable

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DatePeriod5? Period { get; init; } 

    
    #nullable disable
    
}
