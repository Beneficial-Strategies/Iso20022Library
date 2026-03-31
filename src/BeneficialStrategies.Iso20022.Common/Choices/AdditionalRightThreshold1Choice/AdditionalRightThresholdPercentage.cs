// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalRightThreshold1Choice
{
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions. This minimum is expressed as a percentage.
    /// </summary>
    [IsoId("_RDroldp-Ed-ak6NoX_4Aeg_2143895577")]
    [DisplayName("Additional Right Threshold Percentage")]
    public record AdditionalRightThresholdPercentage : AdditionalRightThreshold1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("AddtlRghtThrshldPctg")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
