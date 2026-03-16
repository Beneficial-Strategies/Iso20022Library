// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData62Choice
{
    /// <summary>
    /// State.
    /// </summary>
    [DisplayName("State")]
    public partial record State : TradeData62Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Stat")]
        public required MarginReportData10 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
