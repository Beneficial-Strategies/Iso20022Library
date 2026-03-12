// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData19Choice
{
    /// <summary>
    /// Where no active instruments are present on a venue, this field should be set so that a valid instrument reference data file can be submitted to ESMA as per daily submission requirements.
    /// </summary>
    [IsoId("_nBfoEXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Data Set Action")]
    public partial record DataSetAction : TradeData19Choice_
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
