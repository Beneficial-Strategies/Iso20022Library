// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction2Choice
{
    /// <summary>
    /// Default Option Indicator.
    /// </summary>
    [DisplayName("Default Option Indicator")]
    public partial record DefaultOptionIndicator : DefaultProcessingOrStandingInstruction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DfltOptnInd")]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
