// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date Time2.
/// </summary>
[IsoId("_dSAfYW3iEe6dwbOqHXrHWg")]
[DisplayName("Date Time2")]
public record DateTime2
{
    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }
}
