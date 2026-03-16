// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExecutingParty1Choice
{
    /// <summary>
    /// Indication that the transaction was executed directly by the client.
    /// </summary>
    [IsoId("_OtKNoFiJEea-d4CsgzjlAw")]
    [DisplayName("Client")]
    public record Client : ExecutingParty1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Clnt")]
        public required NoReasonCode Value { get; init; }
    }
}
