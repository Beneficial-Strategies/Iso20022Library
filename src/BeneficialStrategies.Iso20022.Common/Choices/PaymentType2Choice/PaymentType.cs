// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentType2Choice
{
    /// <summary>
    /// Type, or nature, of the payment, eg, express payment.
    /// </summary>
    [IsoId("_RKPjlNp-Ed-ak6NoX_4Aeg_1253363845")]
    [DisplayName("Payment Type")]
    public partial record PaymentType : PaymentType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type, or nature, of the payment.
        /// </summary>
        [IsoXmlTag("PmtTp")]
        public required PaymentType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
