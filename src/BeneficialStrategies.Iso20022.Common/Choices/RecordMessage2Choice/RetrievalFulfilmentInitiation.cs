// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the retrieval fulfilment initiation message.</summary>
    [IsoId("_kNBjzW7-EfC68Y4jZPNEug")]
    [DisplayName("Retrieval Fulfilment Initiation")]
    public record RetrievalFulfilmentInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RtrvlFlfmtInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
