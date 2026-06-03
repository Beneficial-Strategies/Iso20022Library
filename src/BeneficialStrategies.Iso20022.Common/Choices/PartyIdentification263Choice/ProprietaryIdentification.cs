// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification263Choice
{
    /// <summary>Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.</summary>
    [IsoId("_EnMLQ63pEfCN-rGCydxGUA")]
    [DisplayName("Proprietary Identification")]
    public record ProprietaryIdentification : PartyIdentification263Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtryId")]
        public required GenericIdentification36 Value { get; init; }
    }
}
