// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason13Choice
{
    /// <summary>Standard code to specify the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_J1blsa8xEfCx2aBifPEdRg")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason10Code Value { get; init; }
    }
}
