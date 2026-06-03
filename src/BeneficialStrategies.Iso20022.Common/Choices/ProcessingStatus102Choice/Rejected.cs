// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the rejected status.</summary>
    [IsoId("9234f0ff-75e6-4b39-93cf-6fe6ca048eb8")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus36Choice_ Value { get; init; }
    }
}
