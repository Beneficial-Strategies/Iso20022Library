// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat52Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_fFh9EpSoEeeh5JjedkaA_g")]
    [DisplayName("Rate Type And Rate")]
    public record RateTypeAndRate : RateAndAmountFormat52Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_8eXKJZSmEeeh5JjedkaA_g")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required DeemedRateType1Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("_8eXKJJSmEeeh5JjedkaA_g")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; }
    }
}
