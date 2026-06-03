// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the retrieval initiation message.</summary>
    [IsoId("_kNBjyW7-EfC68Y4jZPNEug")]
    [DisplayName("Retrieval Initiation")]
    public record RetrievalInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RtrvlInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
