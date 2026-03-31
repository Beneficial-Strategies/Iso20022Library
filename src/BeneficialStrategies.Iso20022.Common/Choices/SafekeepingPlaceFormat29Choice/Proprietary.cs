// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat29Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_XqXF-bXEEeiTob_PrFFUxA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : SafekeepingPlaceFormat29Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_G3fcIx78EeWW2ZT-VTzGvw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification30 Type { get; init; }

        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_G3fcJR78EeWW2ZT-VTzGvw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; }
    }
}
