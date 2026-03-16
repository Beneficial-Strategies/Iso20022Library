// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice
{
    /// <summary>
    /// Indicates that reporting party is other type of counterparty.
    /// </summary>
    [IsoId("_6j9NN7sAEea-m5tPqiasmQ")]
    [DisplayName("Other")]
    public record Other : CounterpartyTradeNature4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required NoReasonCode Value { get; init; }
    }
}
