// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason76Choice
{
    /// <summary>Pending reason in a proprietary form.</summary>
    [IsoId("_2k33eaKtEfCHi7w3_0pcpw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason76Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
