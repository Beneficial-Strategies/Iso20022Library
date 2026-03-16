// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat15Choice
{
    /// <summary>
    /// Amount To Quantity.
    /// </summary>
    [DisplayName("Amount To Quantity")]
    public partial record AmountToQuantity : SolicitationFeeRateFormat15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtToQty")]
        public required AmountAndQuantityRatio5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
