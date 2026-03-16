// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExecutingParty2Choice
{
    /// <summary>
    /// Client.
    /// </summary>
    [DisplayName("Client")]
    public record Client : ExecutingParty2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Clnt")]
        public required NoReasonCode Value { get; init; }
    }
}
