// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery18Choice
{
    /// <summary>
    /// Ad Hoc Query.
    /// </summary>
    [DisplayName("Ad Hoc Query")]
    public record AdHocQuery : TradeReportQuery18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AdHocQry")]
        public required TradeQueryCriteria14 Value { get; init; }
    }
}
