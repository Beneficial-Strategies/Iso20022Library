// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode6Choice
{
    /// <summary>
    /// Qualifies further the pending status.
    /// </summary>
    [IsoId("_phD1AxbzEeOy-PlRuFSUzQ")]
    [DisplayName("Pending")]
    public record Pending : PaymentStatusCode6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the state of a payment at the clearing agent side is pending.
        /// </summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus4Code Value { get; init; }
    }
}
