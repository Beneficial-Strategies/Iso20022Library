// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdditionalRightThreshold2Choice
{
    /// <summary>
    /// Additional Right Threshold Percentage.
    /// </summary>
    [DisplayName("Additional Right Threshold Percentage")]
    public partial record AdditionalRightThresholdPercentage : AdditionalRightThreshold2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AddtlRghtThrshldPctg")]
        public required IsoPercentage14Rate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
