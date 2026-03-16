// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction12Choice
{
    /// <summary>
    /// Cancellation.
    /// </summary>
    [DisplayName("Cancellation")]
    public partial record Cancellation : CardPaymentDataSetTransaction12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cxl")]
        public required CardPaymentDataSetTransaction46 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
