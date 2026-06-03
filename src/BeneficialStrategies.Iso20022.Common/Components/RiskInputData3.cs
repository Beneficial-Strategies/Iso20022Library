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
[IsoId("_0vBqcT1zEfCQAqQ9lolFUg")]
[DisplayName("Risk Input Data3")]
public record RiskInputData3
{
    /// <summary>
    /// Type of entity providing data for risk assessment.
    /// </summary>
    [IsoId("_0xTiYT1zEfCQAqQ9lolFUg")]
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public ATICAPartyType1Code? EntityType { get; init; }

    /// <summary>
    /// Identifies the type of risk assessment associated with the input data in the message.
    /// </summary>
    [IsoId("_0xTiZT1zEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Value of input data for risk assessment.
    /// </summary>
    [IsoId("_0xTiZz1zEfCQAqQ9lolFUg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required IsoMax10KText Value { get; init; }
}
