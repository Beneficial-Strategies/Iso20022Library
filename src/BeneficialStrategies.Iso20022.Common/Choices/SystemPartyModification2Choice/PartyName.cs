// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_yJhSpYv-Eei289CGNqs21g")]
    [DisplayName("Party Name")]
    public record PartyName : SystemPartyModification2Choice_
    {
        /// <summary>
        /// Specifies the date from which the party name is valid.
        /// </summary>
        [IsoId("_kmfmFO5NEeCisYr99QEiWA_-682796825")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValidFrom { get; init; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_kmfmFe5NEeCisYr99QEiWA_-1679869178")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; }

        /// <summary>
        /// Specifies the short name of the organisation.
        /// </summary>
        [IsoId("_kmpXEO5NEeCisYr99QEiWA_1695064466")]
        [DisplayName("Short Name")]
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ShortName { get; init; }
    }
}
