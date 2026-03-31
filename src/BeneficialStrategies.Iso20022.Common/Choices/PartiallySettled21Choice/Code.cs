// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartiallySettled21Choice
{
    /// <summary>
    /// Partially settled reason expressed as a code.
    /// </summary>
    [IsoId("_SSiV8UHtEeaNSo9he0Belg")]
    [DisplayName("Code")]
    public record Code : PartiallySettled21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Partial settlement status information or information about gating.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettledStatusReason2Code Value { get; init; }
    }
}
