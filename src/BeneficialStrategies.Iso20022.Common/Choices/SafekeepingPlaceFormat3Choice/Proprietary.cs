// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat3Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_SfoCItp-Ed-ak6NoX_4Aeg_-955186305")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : SafekeepingPlaceFormat3Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P-Zbhtp-Ed-ak6NoX_4Aeg_-178701769")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification20 Type { get; init; }

        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
        /// </summary>
        [IsoId("_P-Zbh9p-Ed-ak6NoX_4Aeg_-1061935056")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; }
    }
}
