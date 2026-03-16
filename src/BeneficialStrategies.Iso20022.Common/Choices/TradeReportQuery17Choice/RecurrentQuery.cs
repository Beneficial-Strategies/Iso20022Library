// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery17Choice
{
    /// <summary>
    /// Recurrent Query.
    /// </summary>
    [DisplayName("Recurrent Query")]
    public partial record RecurrentQuery : TradeReportQuery17Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RcrntQry")]
        public required TradeRecurrentQuery5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
