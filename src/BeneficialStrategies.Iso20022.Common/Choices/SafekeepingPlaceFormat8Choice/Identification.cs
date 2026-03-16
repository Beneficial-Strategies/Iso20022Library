// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat8Choice
{
    /// <summary>
    /// Place of safekeeping expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_k06gIR5iEeWDV95LUQhXCA")]
    [DisplayName("Identification")]
    public record Identification : SafekeepingPlaceFormat8Choice_
    {
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_qHV3cR8wEeWKEfczrpCAJA")]
        [DisplayName("Safekeeping Place Type")]
        [IsoXmlTag("SfkpgPlcTp")]
        public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; }

        /// <summary>
        /// Additional information about the place of safekeeping.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Value { get; init; }
    }
}
