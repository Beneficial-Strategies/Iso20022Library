// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification205Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_osYgE46XEemzmeK8_tPygg")]
    [DisplayName("Natural Person")]
    public record NaturalPerson : PartyIdentification205Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_Zfz85T6CEemPvNTzinB5Vw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName1 NameAndAddress { get; init; }

        /// <summary>
        /// CONCAT
        /// </summary>
        [IsoId("_Zfz85j6CEemPvNTzinB5Vw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required NaturalPersonIdentification1 Identification { get; init; }
    }
}
