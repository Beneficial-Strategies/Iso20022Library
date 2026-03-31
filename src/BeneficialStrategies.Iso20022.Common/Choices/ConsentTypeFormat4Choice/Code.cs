// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentTypeFormat4Choice
{
    /// <summary>
    /// Standard code to specify the consent type required.
    /// </summary>
    [IsoId("_d-eJIUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : ConsentTypeFormat4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of consent announced.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConsentType1Code Value { get; init; }
    }
}
