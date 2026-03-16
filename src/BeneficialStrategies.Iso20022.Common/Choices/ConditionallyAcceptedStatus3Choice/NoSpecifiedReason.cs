// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatus3Choice
{
    /// <summary>
    /// No reason available or to report for the conditionally accepted status.
    /// </summary>
    [IsoId("_s1kxxUHXEeamVPoS58KxXA")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : ConditionallyAcceptedStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
