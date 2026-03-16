// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport34Choice
{
    /// <summary>
    /// Margin Update.
    /// </summary>
    [DisplayName("Margin Update")]
    public record MarginUpdate : TradeReport34Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MrgnUpd")]
        public required MarginReportData9 Value { get; init; }
    }
}
