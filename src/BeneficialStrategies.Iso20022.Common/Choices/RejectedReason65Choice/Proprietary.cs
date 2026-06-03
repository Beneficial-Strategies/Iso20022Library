// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason65Choice
{
    /// <summary>Specifies the proprietary value.</summary>
    [IsoId("_Crapmd79Ee-NrtAAlrBEgQ")]
    [DisplayName("Proprietary")]
    public record Proprietary : RejectedReason65Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
