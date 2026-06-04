// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Status43Choice
{
    /// <summary>Status expressed as a matching status.</summary>
    [IsoId("41fb6c32-f077-44f8-bfcc-f14f3124314c")]
    [DisplayName("Matching Status")]
    public record MatchingStatus : Status43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MtchgSts")]
        public required MatchingStatus24Choice_ Value { get; init; }
    }
}
