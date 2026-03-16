// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOrUnderConfirmationChoice1
{
    /// <summary>
    /// Place of presentation when there is a confirmation.
    /// </summary>
    [IsoId("_97kuFHltEeG7BsjMvd1mEw_1998762195")]
    [DisplayName("Presentation Under Confirmation")]
    public record PresentationUnderConfirmation : PlaceOrUnderConfirmationChoice1_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the party to receive the presentation.
        /// </summary>
        [IsoXmlTag("PresntnUdrConf")]
        public required PresentationParty1Code Value { get; init; }
    }
}
