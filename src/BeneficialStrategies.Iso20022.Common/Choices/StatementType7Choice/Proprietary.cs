// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatementType7Choice
{
    /// <summary>Statement type expressed as a proprietary code.</summary>
    [IsoId("_wH_J0QJ3EfGAP_FOfstLIw")]
    [DisplayName("Proprietary")]
    public record Proprietary : StatementType7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
