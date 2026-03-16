// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemStatus3Choice
{
    /// <summary>
    /// Status of the system, in a coded form.
    /// </summary>
    [IsoId("_1iyv8YpbEeiaB-4Hjqs8aw")]
    [DisplayName("Code")]
    public record Code : SystemStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemStatus3Code Value { get; init; }
    }
}
