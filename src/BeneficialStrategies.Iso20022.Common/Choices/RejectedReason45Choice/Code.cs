// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason45Choice
{
    /// <summary>
    /// Rejected reason expressed as a code.
    /// </summary>
    [IsoId("_XD5rgeijEeuLe8v4JEtDDg")]
    [DisplayName("Code")]
    public record Code : RejectedReason45Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transfer or settlement instruction rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason13Code Value { get; init; }
    }
}
