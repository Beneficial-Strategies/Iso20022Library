// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification205Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_osYgEo6XEemzmeK8_tPygg")]
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public record LegalPerson : PartyIdentification205Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_zv1wlz6BEemPvNTzinB5Vw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public PersonName2? NameAndAddress { get; init; }

        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_zv1wlj6BEemPvNTzinB5Vw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification198Choice_ Identification { get; init; }
    }
}
