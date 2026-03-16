// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk Context3.
/// </summary>
[IsoId("_tRk9UXG6Ee60F8I8TAMKmg")]
[DisplayName("Risk Context3")]
public partial record RiskContext3
{
    #nullable enable

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

    
    #nullable disable
    
}
