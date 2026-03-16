// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Direction4Choice
{
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker).
    /// Usage:
    /// DirectionOfTheFirstLeg should be used for most swaps and swap-like contracts including interest rate swaps, credit total return swaps, and equity swaps (except for credit default swaps, variance, volatility, and correlation swaps) as well as for the foreign exchange swaps, forwards and non-deliverable forwards.
    /// </summary>
    [IsoId("_HmpucC0YEe2ZUuvBHegNNg")]
    [DisplayName("Direction")]
    public record Direction : Direction4Choice_
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
}
