// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode6Choice
{
    /// <summary>
    /// Portfolio.
    /// </summary>
    [DisplayName("Portfolio")]
    public partial record Portfolio : CollateralPortfolioCode6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prtfl")]
        public required PortfolioCode3Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
