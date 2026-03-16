// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Other identification of an underlier.
    /// </summary>
    [IsoId("_idD061o2Ee23K4GXSpBSeg")]
    [DisplayName("Other")]
    public record Other : SecurityIdentification41Choice_
    {
        /// <summary>
        /// Indicates other identifier of an underlier.
        /// </summary>
        [IsoId("_D1mToycCEe2BYL6XeAmCWw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public required IsoMax210Text Identification { get; init; }

        /// <summary>
        /// Indicates the source of the identifier that represent the underlier.
        /// </summary>
        [IsoId("_D1mTpScCEe2BYL6XeAmCWw")]
        [DisplayName("Source")]
        [IsoXmlTag("Src")]
        [IsoSimpleType(IsoSimpleType.Max100Text)]
        [StringLength(maximumLength: 100, MinimumLength = 1)]
        public required IsoMax100Text Source { get; init; }
    }
}
