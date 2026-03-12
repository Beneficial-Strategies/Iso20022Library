// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ForeignExchangeSwap2Choice
{
    /// <summary>
    /// Provides the reason why no transactions are being reported for a money market reporting period.
    /// </summary>
    [IsoId("_qm-xUZ2WEeW_58xcYxhewg")]
    [DisplayName("Data Set Action")]
    public partial record DataSetAction : ForeignExchangeSwap2Choice_
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
