// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType10Choice
{
    /// <summary>Fee (charge/commission) expressed as a proprietary code.</summary>
    [IsoId("5ae48e39-09ea-4301-b128-bb77923ca924")]
    [DisplayName("Proprietary")]
    public record Proprietary : ChargeType10Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification47 Value { get; init; }
    }
}
