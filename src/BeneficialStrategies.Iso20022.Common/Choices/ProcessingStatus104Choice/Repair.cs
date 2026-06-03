// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("13fccffd-ac25-4cbd-808e-196dec87fede")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus12Choice_ Value { get; init; }
    }
}
