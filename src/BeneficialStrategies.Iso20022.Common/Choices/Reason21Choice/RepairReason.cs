// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the repair reason.</summary>
    [IsoId("f18cb7f0-7ca3-469f-a99f-f26ad2e3aefa")]
    [DisplayName("Repair Reason")]
    public record RepairReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RprRsn")]
        public required RepairReason11Choice_ Value { get; init; }
    }
}
