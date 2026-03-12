// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport2Choice
{
    /// <summary>
    /// Where no transaction was concluded, this field should be set so that a valid trade data file can be submitted to ESMA as per daily submission requirements.
    /// </summary>
    [IsoId("_fCvncQAFEeqefbt-QjTNnA")]
    [DisplayName("Data Set Action")]
    public partial record DataSetAction : TradeStateReport2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
