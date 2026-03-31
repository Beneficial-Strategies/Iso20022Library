// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityStatus3Choice
{
    /// <summary>
    /// Security status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_GHDbQeLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : SecurityStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecurityStatus2Code Value { get; init; }
    }
}
