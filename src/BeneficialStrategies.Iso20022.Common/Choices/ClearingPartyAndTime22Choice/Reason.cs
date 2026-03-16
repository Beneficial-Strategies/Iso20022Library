// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime22Choice
{
    /// <summary>
    /// Indicates that the contract is intended to be cleared.
    /// </summary>
    [IsoId("_mlkJoRZOEe2QNcZTDeoKnQ")]
    [DisplayName("Reason")]
    public record Reason : ClearingPartyAndTime22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required NoReasonCode Value { get; init; }
    }
}
