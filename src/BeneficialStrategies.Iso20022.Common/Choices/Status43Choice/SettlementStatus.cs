// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Status43Choice
{
    /// <summary>Status expressed as a settlement status.</summary>
    [IsoId("d5d33296-f90a-4cd0-89d9-fc603ec9d6a3")]
    [DisplayName("Settlement Status")]
    public record SettlementStatus : Status43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SttlmSts")]
        public required SettlementStatus30Choice_ Value { get; init; }
    }
}
