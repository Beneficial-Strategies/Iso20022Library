// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OvernightIndexSwap3Choice
{
    /// <summary>
    /// Provides the reason why no transactions are being reported for a money market reporting period.
    /// </summary>
    [IsoId("_zLz70aicEeWHO_l3hf2rlA")]
    [DisplayName("Data Set Action")]
    public record DataSetAction : OvernightIndexSwap3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity1Code Value { get; init; }
    }
}
