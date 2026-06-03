// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the modification requested status.</summary>
    [IsoId("e7ea8564-52c2-4bca-b3b1-c3ece0a8d9b2")]
    [DisplayName("Modification Requested")]
    public record ModificationRequested : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ModReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
