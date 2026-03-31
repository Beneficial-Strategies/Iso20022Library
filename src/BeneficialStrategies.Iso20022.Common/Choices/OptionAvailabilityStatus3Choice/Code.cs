// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionAvailabilityStatus3Choice
{
    /// <summary>
    /// Standard code to specify the status of the option availability.
    /// </summary>
    [IsoId("_tBuQcUEHEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : OptionAvailabilityStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the option availability.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionAvailabilityStatus1Code Value { get; init; }
    }
}
