// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements indicating the direction of the derivative transaction.
/// </summary>
[IsoId("_9zN68C0WEe2ZUuvBHegNNg")]
[DisplayName("Direction")]
public record Direction2
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_gC-v4C0XEe2ZUuvBHegNNg")]
    [DisplayName("Direction Of The First Leg")]
    [IsoXmlTag("DrctnOfTheFrstLeg")]
    public required OptionParty3Code DirectionOfTheFirstLeg { get; init; }

    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the second leg as determined at the time of transaction.
    /// </summary>
    [IsoId("_p5uykC0XEe2ZUuvBHegNNg")]
    [DisplayName("Direction Of The Second Leg")]
    [IsoXmlTag("DrctnOfTheScndLeg")]
    public OptionParty3Code? DirectionOfTheSecondLeg { get; init; }
}
