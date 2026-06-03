// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("327078f5-f62e-48f7-9fbc-6a1672e5a36f")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus12Choice_ Value { get; init; }
    }
}
