// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.QuorumQuantity2Choice
{
    /// <summary>
    /// Quorum Quantity Percentage.
    /// </summary>
    [DisplayName("Quorum Quantity Percentage")]
    public partial record QuorumQuantityPercentage : QuorumQuantity2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("QrmQtyPctg")]
        public required IsoPercentage14Rate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
