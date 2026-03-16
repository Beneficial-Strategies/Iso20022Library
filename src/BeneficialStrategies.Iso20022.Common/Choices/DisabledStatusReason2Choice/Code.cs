// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisabledStatusReason2Choice
{
    /// <summary>
    /// Reason for the disabled account status expressed as a code.
    /// </summary>
    [IsoId("_hnIFMUzAEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public record Code : DisabledStatusReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason an account is disabled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DisabledReason2Code Value { get; init; }
    }
}
