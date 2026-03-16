// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode6Choice
{
    /// <summary>
    /// Qualifies further the final status.
    /// </summary>
    [IsoId("_phD1BRbzEeOy-PlRuFSUzQ")]
    [DisplayName("Final")]
    public record Final : PaymentStatusCode6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the final status of a transaction.
        /// </summary>
        [IsoXmlTag("Fnl")]
        public required FinalStatus1Code Value { get; init; }
    }
}
