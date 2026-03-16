// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference15Choice
{
    /// <summary>
    /// Executing Party Transaction Identification.
    /// </summary>
    [DisplayName("Executing Party Transaction Identification")]
    public record ExecutingPartyTransactionIdentification : IdentificationReference15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ExctgPtyTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
