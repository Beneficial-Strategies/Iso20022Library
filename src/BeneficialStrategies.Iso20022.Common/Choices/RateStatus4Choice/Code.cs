// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateStatus4Choice
{
    /// <summary>
    /// Standard code to specify the status of the rate.
    /// </summary>
    [IsoId("_cj9gA5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : RateStatus4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateStatus1Code Value { get; init; }
    }
}
