// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentSchemeChoice
{
    /// <summary>
    /// Specifies the channel through which the payment instruction is to be processed in coded form.
    /// </summary>
    [IsoId("_QHyBD9p-Ed-ak6NoX_4Aeg_-1149658812")]
    [DisplayName("Code")]
    public partial record Code : PaymentSchemeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of payment system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CashClearingSystem2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
