// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status40Choice
{
    /// <summary>Status expressed as order details report.</summary>
    [IsoId("a447d08c-7c2b-44cc-9348-b5d601e991f0")]
    [DisplayName("Order Details Report")]
    public record OrderDetailsReport : Status40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OrdrDtlsRpt")]
        public required OrderStatusAndReason11 Value { get; init; }
    }
}
