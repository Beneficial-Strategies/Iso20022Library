// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure8Choice
{
    /// <summary>
    /// Unit of measure, in a proprietary format.
    /// </summary>
    [IsoId("_7nKuQDNlEe2UWZuK9pqFtg")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : UnitOfMeasure8Choice_
    {
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_KoMOQQbpEeqrW7Meu5r3kQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max72Text)]
        [StringLength(maximumLength: 72, MinimumLength = 1)]
        public required IsoMax72Text Identification { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_KoMOQwbpEeqrW7Meu5r3kQ")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_KoMORQbpEeqrW7Meu5r3kQ")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
