// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus70Choice
{
    /// <summary>Specifies the processing status as a code.</summary>
    [IsoId("_mXWx0eGHEeWCAvUNsZ5u6g")]
    [DisplayName("Code")]
    public record Code : ProcessingStatus70Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required TransactionProcessingStatus4Code Value { get; init; }
    }
}
