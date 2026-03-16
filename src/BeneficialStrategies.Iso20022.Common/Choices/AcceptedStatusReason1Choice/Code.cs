// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatusReason1Choice
{
    /// <summary>
    /// Reason for the status expressed as a code.
    /// </summary>
    [IsoId("_wdDRcWBlEeaR1OOiVxm3Gg")]
    [DisplayName("Code")]
    public record Code : AcceptedStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for an accepted status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AcceptedStatusReason1Code Value { get; init; }
    }
}
