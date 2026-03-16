// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode6Choice
{
    /// <summary>
    /// Margin Portfolio Code.
    /// </summary>
    [DisplayName("Margin Portfolio Code")]
    public partial record MarginPortfolioCode : CollateralPortfolioCode6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MrgnPrtflCd")]
        public required MarginPortfolio4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
