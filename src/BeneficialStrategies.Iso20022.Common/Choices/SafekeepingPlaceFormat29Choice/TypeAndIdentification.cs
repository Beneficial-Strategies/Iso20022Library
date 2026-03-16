// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat29Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a type and identification.
    /// </summary>
    [IsoId("_XqXF8bXEEeiTob_PrFFUxA")]
    [DisplayName("Type And Identification")]
    public record TypeAndIdentification : SafekeepingPlaceFormat29Choice_
    {
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_W1QC0bXEEeiTob_PrFFUxA")]
        [DisplayName("Safekeeping Place Type")]
        [IsoXmlTag("SfkpgPlcTp")]
        public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; }

        /// <summary>
        /// Place of safekeeping.
        /// </summary>
        [IsoId("_W1QC07XEEeiTob_PrFFUxA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public required IsoAnyBICDec2014Identifier Identification { get; init; }
    }
}
