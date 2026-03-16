// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport34Choice
{
    /// <summary>
    /// New.
    /// </summary>
    [DisplayName("New")]
    public partial record New : TradeReport34Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("New")]
        public required MarginReportData9 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
