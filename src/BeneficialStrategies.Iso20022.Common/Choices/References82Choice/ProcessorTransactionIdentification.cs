// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the processor transaction identification.</summary>
    [IsoId("_4SiC2eSlEe-qVZLXW4RRBw")]
    [DisplayName("Processor Transaction Identification")]
    public record ProcessorTransactionIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrcrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
