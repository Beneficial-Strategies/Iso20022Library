// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty3Choice
{
    /// <summary>
    /// Where no reporting data are available, this field should be set so that a valid reference data file can be submitted to the competent authority as per submission requirements.
    /// </summary>
    [IsoId("_68V3Ac2GEeqFGLkKbAvCGg")]
    [DisplayName("Data Set Action")]
    public record DataSetAction : StatisticsPerCounterparty3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity1Code Value { get; init; }
    }
}
