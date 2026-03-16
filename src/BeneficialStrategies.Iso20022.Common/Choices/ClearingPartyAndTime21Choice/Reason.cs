// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime21Choice
{
    /// <summary>
    /// Indicates that the contract is cleared.
    /// </summary>
    [IsoId("_91accwtuEe2eQ-C-GTDpFA")]
    [DisplayName("Reason")]
    public record Reason : ClearingPartyAndTime21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required NoReasonCode Value { get; init; }
    }
}
