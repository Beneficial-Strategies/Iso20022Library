// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the rejected status.</summary>
    [IsoId("8320b8e6-48e5-42ad-92a5-ae1a558156b6")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus39Choice_ Value { get; init; }
    }
}
