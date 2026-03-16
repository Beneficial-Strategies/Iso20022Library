// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification231Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_ow34ofQ0EeqAradXpAelDQ")]
    [DisplayName("Legal Person")]
    public record LegalPerson : PartyIdentification231Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_IWSDUa-EEemJ1NnLPsTFaw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName2 NameAndAddress { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_YAIGAa-EEemJ1NnLPsTFaw")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; }

        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_IWSDUK-EEemJ1NnLPsTFaw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification198Choice_ Identification { get; init; }
    }
}
