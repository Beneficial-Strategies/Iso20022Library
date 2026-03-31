// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData35Choice
{
    /// <summary>
    /// Where no transaction was concluded, this field should be set so that a valid transaction data file can be submitted to ESMA as per daily submission requirements.
    /// </summary>
    [IsoId("_hSAnIcK4EeuFNp8LZAnorg")]
    [DisplayName("Data Set Action")]
    public record DataSetAction : TradeData35Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity1Code Value { get; init; }
    }
}
