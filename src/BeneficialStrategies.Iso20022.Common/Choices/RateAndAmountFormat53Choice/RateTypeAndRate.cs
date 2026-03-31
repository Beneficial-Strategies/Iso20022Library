// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat53Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_6juhfdBaEee0mNiKMkpGNQ")]
    [DisplayName("Rate Type And Rate")]
    [IsoXmlTag("RateTpAndRate")]
    public record RateTypeAndRate : RateAndAmountFormat53Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_oGkXodBcEee0mNiKMkpGNQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required DeemedRateType2Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("_oGkXo9BcEee0mNiKMkpGNQ")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; }
    }
}
