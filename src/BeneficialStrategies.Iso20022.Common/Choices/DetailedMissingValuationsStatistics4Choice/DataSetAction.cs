// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingValuationsStatistics4Choice
{
    /// <summary>
    /// Specifies the type of report activity for a specific reporting period.
    /// </summary>
    [IsoId("_x1GY4VyGEe24CqbZJK5XxA")]
    [DisplayName("Data Set Action")]
    public record DataSetAction : DetailedMissingValuationsStatistics4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity1Code Value { get; init; }
    }
}
