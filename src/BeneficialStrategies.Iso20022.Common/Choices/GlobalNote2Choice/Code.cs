// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GlobalNote2Choice
{
    /// <summary>
    /// Global note expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_TsvfweLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : GlobalNote2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GlobalNote1Code Value { get; init; }
    }
}
