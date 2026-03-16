// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument99Choice
{
    /// <summary>
    /// Strategy Instruments.
    /// </summary>
    [DisplayName("Strategy Instruments")]
    public partial record StrategyInstruments : FinancialInstrument99Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StrtgyInstrms")]
        public required IsoISINOct2015Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
