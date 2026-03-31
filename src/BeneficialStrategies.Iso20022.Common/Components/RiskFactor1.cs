// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variable, index, benchmark or other price used in the valuation of a financial instrument.
/// </summary>
[IsoId("_8KUvwKs2Eeayv9XxdmMwKQ")]
[DisplayName("Risk Factor")]
public record RiskFactor1
{
    /// <summary>
    /// Unique identifier for the risk factor.
    /// </summary>
    [IsoId("_BrXWcKs3Eeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Assumed stress move of the associated stress item under the scenario.
    /// </summary>
    [IsoId("_EhdZ0Ks3Eeayv9XxdmMwKQ")]
    [DisplayName("Stress Size")]
    [IsoXmlTag("StrssSz")]
    public required StressSize1Choice_ StressSize { get; init; }
}
