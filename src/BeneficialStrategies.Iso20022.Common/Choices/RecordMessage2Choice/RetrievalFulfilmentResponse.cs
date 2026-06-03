// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the retrieval fulfilment response message.</summary>
    [IsoId("_kNBjz27-EfC68Y4jZPNEug")]
    [DisplayName("Retrieval Fulfilment Response")]
    public record RetrievalFulfilmentResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RtrvlFlfmtRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
