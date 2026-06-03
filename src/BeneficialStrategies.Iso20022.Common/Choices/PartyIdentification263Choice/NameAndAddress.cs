// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification263Choice
{
    /// <summary>Name and address of the party.</summary>
    [IsoId("_EnMLRa3pEfCN-rGCydxGUA")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification263Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NmAndAdr")]
        public required NameAndAddress5 Value { get; init; }
    }
}
