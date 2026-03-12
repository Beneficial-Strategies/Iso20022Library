// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeQueryExecutionFrequency1Choice
{
    /// <summary>
    /// Query is executed on a daily basis.
    /// </summary>
    [IsoId("_k1MacNGYEeaQk737TH1Fzw")]
    [DisplayName("Daily")]
    public partial record Daily : TradeQueryExecutionFrequency1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Daly")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
