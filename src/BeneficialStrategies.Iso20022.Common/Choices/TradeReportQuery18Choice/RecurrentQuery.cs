// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery18Choice
{
    /// <summary>
    /// Recurrent Query.
    /// </summary>
    [DisplayName("Recurrent Query")]
    public record RecurrentQuery : TradeReportQuery18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RcrntQry")]
        public required TradeRecurrentQuery7 Value { get; init; }
    }
}
