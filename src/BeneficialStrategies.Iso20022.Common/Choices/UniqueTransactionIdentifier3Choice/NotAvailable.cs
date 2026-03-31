// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UniqueTransactionIdentifier3Choice
{
    /// <summary>
    /// Indicates unique transaction identifier is not available.
    /// </summary>
    [IsoId("__pAKxU7qEe2PGo0mhYCh1g")]
    [DisplayName("Not Available")]
    public record NotAvailable : UniqueTransactionIdentifier3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NotAvlbl")]
        public required NoReasonCode Value { get; init; }
    }
}
