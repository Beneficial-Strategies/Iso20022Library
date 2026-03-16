// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification234Choice
{
    /// <summary>
    /// Individual local country specific identification of the owner agreed between the account servicer and account owner.
    /// </summary>
    [IsoId("_F-iyOR9REeuFz_FaCzCLgQ")]
    [DisplayName("Individual Owner Identification")]
    public record IndividualOwnerIdentification : PartyIdentification234Choice_
    {
        /// <summary>
        /// Specifies the type of alternate identification of the party identified.
        /// </summary>
        [IsoId("_BbMrdR5gEeWE3PufGMdJ3w")]
        [DisplayName("Identification Type")]
        [IsoXmlTag("IdTp")]
        public required IdentificationType42Choice_ IdentificationType { get; init; }

        /// <summary>
        /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
        /// </summary>
        [IsoId("_BbMrfR5gEeWE3PufGMdJ3w")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public required CountryCode Country { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_BbMrhR5gEeWE3PufGMdJ3w")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text AlternateIdentification { get; init; }
    }
}
