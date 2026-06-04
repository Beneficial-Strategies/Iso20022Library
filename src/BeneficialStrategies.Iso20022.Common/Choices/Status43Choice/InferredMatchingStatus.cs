// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Status43Choice
{
    /// <summary>Status expressed as an inferred matching status.</summary>
    [IsoId("b8b4b0f9-0bda-4676-84c5-fb4dc8ce97e4")]
    [DisplayName("Inferred Matching Status")]
    public record InferredMatchingStatus : Status43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IfrrdMtchgSts")]
        public required MatchingStatus24Choice_ Value { get; init; }
    }
}
