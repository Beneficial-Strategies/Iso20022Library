// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeQueryExecutionFrequency1Choice
{
    /// <summary>
    /// Query is executed on a weekly basis. The day of the week for the query execution should be specified.
    /// </summary>
    [IsoId("_lyvAwNGYEeaQk737TH1Fzw")]
    [DisplayName("Weekly")]
    public record Weekly : TradeQueryExecutionFrequency1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the day of the week of the delivery.
        /// </summary>
        [IsoXmlTag("Wkly")]
        public required WeekDay2Code Value { get; init; }
    }
}
