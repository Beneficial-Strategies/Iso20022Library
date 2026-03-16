// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional data to be considered for risk assessment.
/// </summary>
[IsoId("_89Mi8EbNEeeIjf8aP9KbJA")]
[DisplayName("Risk Input Data")]
public record RiskInputData1
{
    /// <summary>
    /// Entity providing the information required for a risk assessment.
    /// </summary>
    [IsoId("_pfrpcNv-EeeOusYHZbyj7w")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public RiskAssessmentDataEntityProvider1? Entity { get; init; }

    /// <summary>
    /// Identifies the type of risk assessment associated with the input data in the message.
    /// </summary>
    [IsoId("_Soz60EbOEeeIjf8aP9KbJA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Value of input data for risk assessment.
    /// </summary>
    [IsoId("_ZjTnwEbOEeeIjf8aP9KbJA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max10KText)]
    [StringLength(maximumLength: 10000, MinimumLength = 1)]
    public required IsoMax10KText Value { get; init; }
}
