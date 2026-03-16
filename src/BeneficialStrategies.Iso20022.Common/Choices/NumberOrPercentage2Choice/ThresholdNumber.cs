// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NumberOrPercentage2Choice
{
    /// <summary>
    /// Threshold Number.
    /// </summary>
    [DisplayName("Threshold Number")]
    public partial record ThresholdNumber : NumberOrPercentage2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ThrshldNb")]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
