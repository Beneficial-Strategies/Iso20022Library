// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentType3Choice
{
    /// <summary>
    /// Type, or nature, of the payment, such as express payment.|.
    /// </summary>
    [IsoId("_72YTAKMgEeCJ6YNENx4h-w_166956886")]
    [DisplayName("Code")]
    public partial record Code : PaymentType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type, or nature, of the payment.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
