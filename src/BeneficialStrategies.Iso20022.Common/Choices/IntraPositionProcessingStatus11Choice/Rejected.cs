// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus11Choice
{
    /// <summary>Instruction has been rejected for further processing.</summary>
    [IsoId("309dbc58-f163-40b1-8f52-ca4e46953c1b")]
    [DisplayName("Rejected")]
    public record Rejected : IntraPositionProcessingStatus11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionOrRepairStatus41Choice_ Value { get; init; }
    }
}
