// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification262Choice
{
    /// <summary>Name and address of the party.</summary>
    [IsoId("f1064847-9bd1-4d5e-8b59-38bd1ed740a7")]
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification262Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NmAndAdr")]
        public required NameAndAddress5 Value { get; init; }
    }
}
