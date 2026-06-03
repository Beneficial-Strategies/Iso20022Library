// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType11Choice
{
    /// <summary>Charge type expressed as an extended code.</summary>
    [IsoId("36d434f4-4cf5-47c6-9d48-85d48f2ed439")]
    [DisplayName("Proprietary")]
    public record Proprietary : ChargeType11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
