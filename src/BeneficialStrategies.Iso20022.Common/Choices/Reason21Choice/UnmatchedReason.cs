// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the unmatched reason.</summary>
    [IsoId("ea90df78-128e-42a2-8934-72ced0729b58")]
    [DisplayName("Unmatched Reason")]
    public record UnmatchedReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UmtchdRsn")]
        public required UnmatchedReason22Choice_ Value { get; init; }
    }
}
