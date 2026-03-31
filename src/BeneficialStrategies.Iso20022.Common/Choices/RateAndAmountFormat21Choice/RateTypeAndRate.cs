// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat21Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_y_GILyeOEeOXAt_43VmZGw")]
    [DisplayName("Rate Type And Rate")]
    [IsoXmlTag("RateTpAndRate")]
    public record RateTypeAndRate : RateAndAmountFormat21Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_83lbsCeEEeOXAt_43VmZGw")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType28Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("_91nxQCeEEeOXAt_43VmZGw")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Rate { get; init; }
    }
}
