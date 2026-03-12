// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity12Choice
{
    /// <summary>
    /// Percentage rate of assets to be transferred.
    /// </summary>
    [IsoId("_z2O69PsrEeCUd_EZYqZ_Uw")]
    [DisplayName("Percentage Rate")]
    public partial record PercentageRate : Quantity12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("PctgRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
