// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice
{
    /// <summary>Underlying data expressed as statement entry details.</summary>
    [IsoId("cee69114-e6ca-4fa5-8f7d-c42aac258938")]
    [DisplayName("Statement Entry")]
    public record StatementEntry : UnderlyingData13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("StmtNtry")]
        public required UnderlyingStatementEntry11 Value { get; init; }
    }
}
