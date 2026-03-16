// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RegistrationProcessingStatus3Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_giL60TqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : RegistrationProcessingStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the registration processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RegistrationProcessingStatus1Code Value { get; init; }
    }
}
