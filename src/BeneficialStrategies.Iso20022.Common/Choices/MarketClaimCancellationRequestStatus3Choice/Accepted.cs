// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice
{
    /// <summary>Instruction cancellation request has been accepted.</summary>
    [IsoId("_Jg5gKa8xEfCx2aBifPEdRg")]
    [DisplayName("Accepted")]
    public record Accepted : MarketClaimCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Accptd")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
