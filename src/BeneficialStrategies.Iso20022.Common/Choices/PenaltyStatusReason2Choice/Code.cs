// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PenaltyStatusReason2Choice
{
    /// <summary>Penalty status reason, in a coded form.</summary>
    [IsoId("_vUsvER-DEeuwwezkzufkMw")]
    [DisplayName("Code")]
    public record Code : PenaltyStatusReason2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PenaltyStatusReason2Code Value { get; init; }
    }
}
