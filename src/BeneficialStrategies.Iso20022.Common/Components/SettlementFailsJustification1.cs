// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the justification for the derogation justification on the reporting of settlement fails instructions.
/// </summary>
[IsoId("_TKY2UMs0EemSav3hRKzWyg")]
[DisplayName("Settlement Fails Justification")]
public record SettlementFailsJustification1
{
    /// <summary>
    /// Specifies the value of settlement fails, which does not exceed the limit value as specified in the local regulation.
    /// </summary>
    [IsoId("_TKY2Uss0EemSav3hRKzWyg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveDecimalNumber)]
    public required IsoMax20PositiveDecimalNumber Value { get; init; }

    /// <summary>
    /// Specifies the rate of settlement fails, which does not exceed the limits rate as specified in the local regulation.
    /// </summary>
    [IsoId("_TKY2U8s0EemSav3hRKzWyg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public required SettlementDataRate1Choice_ Rate { get; init; }
}
