// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NumberOrPercentage2Choice
{
    /// <summary>
    /// Threshold Percentage.
    /// </summary>
    [DisplayName("Threshold Percentage")]
    public partial record ThresholdPercentage : NumberOrPercentage2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ThrshldPctg")]
        public required IsoPercentage14Rate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
