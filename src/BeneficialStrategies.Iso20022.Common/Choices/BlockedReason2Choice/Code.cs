// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BlockedReason2Choice
{
    /// <summary>
    /// Reason expressed as a code.
    /// </summary>
    [IsoId("_P2OO0Vr3Eea4y99eritluQ")]
    [DisplayName("Code")]
    public record Code : BlockedReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason an account is blocked.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BlockedReason2Code Value { get; init; }
    }
}
