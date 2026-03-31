// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UniqueProductIdentifier2Choice
{
    /// <summary>
    /// Product identifier expressed in a proprietary notation.
    /// </summary>
    [IsoId("__0j-A2ETEe2P-L9DBerEgA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : UniqueProductIdentifier2Choice_
    {
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_XQzmAWEUEe2P-L9DBerEgA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max100Text)]
        [StringLength(maximumLength: 100, MinimumLength = 1)]
        public required IsoMax100Text Identification { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_XQzmA2EUEe2P-L9DBerEgA")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_XQzmBWEUEe2P-L9DBerEgA")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
