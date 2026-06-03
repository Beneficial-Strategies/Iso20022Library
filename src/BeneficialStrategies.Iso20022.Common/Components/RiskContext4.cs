// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the risk associated with the transaction.
/// </summary>
[IsoId("_yM0MYT1zEfCQAqQ9lolFUg")]
[DisplayName("Risk Context4")]
public record RiskContext4
{
    /// <summary>
    /// Input data to be considered in a risk assessment.
    /// </summary>
    [IsoId("_yPNZET1zEfCQAqQ9lolFUg")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public ValueList<RiskInputData3> InputData { get; init; } = [];

    /// <summary>
    /// Indicates the level of risk associated with the transaction.
    /// </summary>
    [IsoId("_yPNZEz1zEfCQAqQ9lolFUg")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<RiskAssessment4> Assessment { get; init; } = [];
}
