// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference16Choice
{
    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    public record UniqueTransactionIdentifier : IdentificationReference16Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UnqTxIdr")]
        public required IsoUTIIdentifier Value { get; init; }
    }
}
