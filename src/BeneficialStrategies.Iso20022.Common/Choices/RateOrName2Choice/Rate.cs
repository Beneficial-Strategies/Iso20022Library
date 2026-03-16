// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateOrName2Choice
{
    /// <summary>
    /// Pricing expressed as a rate.
    /// </summary>
    [IsoId("_XO3Yd9p-Ed-ak6NoX_4Aeg_1588721411")]
    [DisplayName("Rate")]
    public record Rate : RateOrName2Choice_
    {
        /// <summary>
        /// Indicates the sign of the rate.
        /// </summary>
        [IsoId("_Q-xTYNp-Ed-ak6NoX_4Aeg_-1215412849")]
        [DisplayName("Sign")]
        [IsoXmlTag("Sgn")]
        [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
        public IsoPlusOrMinusIndicator? Sign { get; init; }

        /// <summary>
        /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
        /// </summary>
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
