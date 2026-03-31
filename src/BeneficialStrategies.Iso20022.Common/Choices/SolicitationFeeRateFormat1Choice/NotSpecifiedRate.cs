// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat1Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_UOMcydp-Ed-ak6NoX_4Aeg_-1900141564")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : SolicitationFeeRateFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType6Code Value { get; init; }
    }
}
