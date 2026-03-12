// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentType5Choice
{
    /// <summary>
    /// Type, or nature, of the payment.
    /// </summary>
    [IsoId("_nQ0J4ekAEemV35DUs8L82Q")]
    [DisplayName("Type")]
    public partial record Type : PaymentType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type, or nature, of the payment.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required PaymentType4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
