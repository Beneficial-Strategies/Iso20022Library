// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat34Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_9C3BIffEEeiNZp_PtLohLw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : SafekeepingPlaceFormat34Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_VyigCZqLEeWcAIE4lEkF_Q")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification47 Type { get; init; }

        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_VyigC5qLEeWcAIE4lEkF_Q")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public IsoRestrictedFINXMax30Text? Identification { get; init; }
    }
}
