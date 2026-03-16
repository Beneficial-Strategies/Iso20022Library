// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification223Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_1G7dFK-EEemJ1NnLPsTFaw")]
    [DisplayName("Natural Person")]
    public record NaturalPerson : PartyIdentification223Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_e_o11a-EEemJ1NnLPsTFaw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName1 NameAndAddress { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_oP6HUa-EEemJ1NnLPsTFaw")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; }

        /// <summary>
        /// Natural person local identification and type.
        /// </summary>
        [IsoId("_e_o11K-EEemJ1NnLPsTFaw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required NaturalPersonIdentification1 Identification { get; init; }
    }
}
