// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification263Choice
{
    /// <summary>Unique and unambiguous identification of a person, for example a passport.</summary>
    [IsoId("_EnMLR63pEfCN-rGCydxGUA")]
    [DisplayName("Individual Owner Identification")]
    public record IndividualOwnerIdentification : PartyIdentification263Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IndvOwnrId")]
        public required AlternatePartyIdentification7 Value { get; init; }
    }
}
