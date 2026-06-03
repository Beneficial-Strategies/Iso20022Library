// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EUDividendStatusType3Choice
{
    /// <summary>Trade conditions expressed as an extended code.</summary>
    [IsoId("c652129c-d9b2-41eb-98a2-a58616695ba5")]
    [DisplayName("Proprietary")]
    public record Proprietary : EUDividendStatusType3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
