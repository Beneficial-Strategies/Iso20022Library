// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat11Choice
{
    /// <summary>
    /// Place of safekeeping expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_cdRpW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public record Identification : SafekeepingPlaceFormat11Choice_
    {
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_cdSQFZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Place Type")]
        [IsoXmlTag("SfkpgPlcTp")]
        public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; }

        /// <summary>
        /// Additional information about the place of safekeeping.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public IsoRestrictedFINXMax30Text? Value { get; init; }
    }
}
