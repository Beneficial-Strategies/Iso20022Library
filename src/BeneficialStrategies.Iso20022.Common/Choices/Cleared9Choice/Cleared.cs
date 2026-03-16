// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared9Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_4paV4ZQPEeiok48Eh9lW9Q")]
    [DisplayName("Cleared")]
    public record Cleared : Cleared9Choice_
    {
        /// <summary>
        /// In the case of a contract that has been cleared, the unique code for the CCP that has cleared the contract.
        /// </summary>
        [IsoId("_jtjnA5QPEeiok48Eh9lW9Q")]
        [DisplayName("CCP")]
        [IsoXmlTag("CCP")]
        public OrganisationIdentification9Choice_? CCP { get; init; }

        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_jtjnBZQPEeiok48Eh9lW9Q")]
        [DisplayName("Clearing Date Time")]
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingDateTime { get; init; }
    }
}
