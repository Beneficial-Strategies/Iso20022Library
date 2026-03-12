// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OvernightIndexSwap4Choice
{
    /// <summary>
    /// Provides the reason why no transactions are being reported for a money market reporting period.
    /// </summary>
    [IsoId("_G1Uq8cEREea7jLfvGi1PDw")]
    [DisplayName("Data Set Action")]
    public partial record DataSetAction : OvernightIndexSwap4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of report activity for a specific reporting period.
        /// </summary>
        [IsoXmlTag("DataSetActn")]
        public required ReportPeriodActivity3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
