// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason68Choice
{
    /// <summary>Specifies the proprietary value.</summary>
    [IsoId("_pS4SaaKsEfCHi7w3_0pcpw")]
    [DisplayName("Proprietary")]
    public record Proprietary : RejectedReason68Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
