// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the reversal initiation message.</summary>
    [IsoId("_kNBj0W7-EfC68Y4jZPNEug")]
    [DisplayName("Reversal Initiation")]
    public record ReversalInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RvslInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
