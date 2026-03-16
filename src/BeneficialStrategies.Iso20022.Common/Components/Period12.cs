// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Period12.
/// </summary>
[IsoId("_1d5nse3_Ee6nAu63uIo75Q")]
[DisplayName("Period12")]
public record Period12
{
    /// <summary>
    /// End Date.
    /// </summary>
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat45Choice_ EndDate { get; init; }

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat45Choice_ StartDate { get; init; }
}
