// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty18Choice
{
    /// <summary>
    /// Report.
    /// </summary>
    [DisplayName("Report")]
    public partial record Report : StatisticsPerCounterparty18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rpt")]
        public required DetailedStatisticsPerCounterparty19 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
