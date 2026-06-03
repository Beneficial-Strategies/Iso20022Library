// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the retrieval response message.</summary>
    [IsoId("_kNBjy27-EfC68Y4jZPNEug")]
    [DisplayName("Retrieval Response")]
    public record RetrievalResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RtrvlRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
