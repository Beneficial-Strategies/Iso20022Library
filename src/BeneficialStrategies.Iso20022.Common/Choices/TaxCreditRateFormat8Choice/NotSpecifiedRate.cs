// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat8Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_XFqMbUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : TaxCreditRateFormat8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType7Code Value { get; init; }
    }
}
