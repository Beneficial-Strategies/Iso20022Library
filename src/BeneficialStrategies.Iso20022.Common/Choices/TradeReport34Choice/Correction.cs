// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport34Choice
{
    /// <summary>
    /// Correction.
    /// </summary>
    [DisplayName("Correction")]
    public record Correction : TradeReport34Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Crrctn")]
        public required MarginReportData9 Value { get; init; }
    }
}
