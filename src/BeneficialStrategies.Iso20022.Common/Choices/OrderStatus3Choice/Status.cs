// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice
{
    /// <summary>
    /// Status of all the orders in the order message. There is no reason attached.
    /// </summary>
    [IsoId("_vIDnYUH7EeaV3ab_pHzFIQ")]
    [DisplayName("Status")]
    public partial record Status : OrderStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the current status of the order.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required OrderStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
