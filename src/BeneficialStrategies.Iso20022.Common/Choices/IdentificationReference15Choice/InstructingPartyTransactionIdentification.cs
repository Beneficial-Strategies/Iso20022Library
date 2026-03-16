// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference15Choice
{
    /// <summary>
    /// Instructing Party Transaction Identification.
    /// </summary>
    [DisplayName("Instructing Party Transaction Identification")]
    public record InstructingPartyTransactionIdentification : IdentificationReference15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("InstgPtyTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
