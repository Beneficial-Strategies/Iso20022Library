// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosedStatusReason2Choice
{
    /// <summary>
    /// Reason for the closed account status expressed as a code.
    /// </summary>
    [IsoId("_lSNvgUzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public record Code : ClosedStatusReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the closed status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ClosedStatusReason1Code Value { get; init; }
    }
}
