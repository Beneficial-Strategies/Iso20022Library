// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the cancellation reason.</summary>
    [IsoId("8e662273-eee2-4c90-8e72-adfee3e9a518")]
    [DisplayName("Cancellation Reason")]
    public record CancellationReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlRsn")]
        public required CancellationReason20Choice_ Value { get; init; }
    }
}
