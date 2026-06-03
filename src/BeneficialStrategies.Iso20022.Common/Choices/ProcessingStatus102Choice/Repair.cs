// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("db0716c3-fcd4-4fba-a104-4ceb02f6d78b")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus14Choice_ Value { get; init; }
    }
}
