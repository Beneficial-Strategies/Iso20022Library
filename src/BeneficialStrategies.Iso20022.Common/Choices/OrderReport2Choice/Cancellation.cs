// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderReport2Choice
{
    /// <summary>
    /// Cancellation.
    /// </summary>
    [DisplayName("Cancellation")]
    public partial record Cancellation : OrderReport2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cxl")]
        public required CancelOrderReport1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
