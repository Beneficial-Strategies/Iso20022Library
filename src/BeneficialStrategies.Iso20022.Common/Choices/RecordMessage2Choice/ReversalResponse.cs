// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the reversal response message.</summary>
    [IsoId("_kNBj027-EfC68Y4jZPNEug")]
    [DisplayName("Reversal Response")]
    public record ReversalResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RvslRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
