// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus33Choice
{
    /// <summary>Status of the order cancellation request is cancelled.</summary>
    [IsoId("03fa80d1-c80b-4026-9152-8183ae3e371b")]
    [DisplayName("Status")]
    public record Status : CancellationStatus33Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sts")]
        public required OrderCancellationStatus2Code Value { get; init; }
    }
}
