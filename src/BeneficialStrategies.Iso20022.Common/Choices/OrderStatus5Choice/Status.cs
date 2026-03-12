// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice
{
    /// <summary>
    /// Status of the individual order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_P8YAl0HREeasdbKMiqizqA")]
    [DisplayName("Status")]
    public partial record Status : OrderStatus5Choice_
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
