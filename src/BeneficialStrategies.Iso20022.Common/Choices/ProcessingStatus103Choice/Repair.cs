// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("bce3de89-8fee-4a56-92cb-36a5001e133e")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus12Choice_ Value { get; init; }
    }
}
