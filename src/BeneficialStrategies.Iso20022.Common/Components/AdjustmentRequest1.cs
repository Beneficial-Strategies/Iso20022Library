// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Adjustment Request1.
/// </summary>
[IsoId("_hWdscRc0Ee6CaqQSK5g6qw")]
[DisplayName("Adjustment Request1")]
public record AdjustmentRequest1
{
    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DatePeriod5? Period { get; init; }
}
