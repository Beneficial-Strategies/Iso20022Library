// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk Context3.
/// </summary>
[IsoId("_tRk9UXG6Ee60F8I8TAMKmg")]
[DisplayName("Risk Context3")]
public record RiskContext3
{
    /// <summary>
    /// Assessment.
    /// </summary>
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<RiskAssessment3> Assessment { get; init; } = [];

    /// <summary>
    /// Input Data.
    /// </summary>
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public ValueList<RiskInputData2> InputData { get; init; } = [];
}
