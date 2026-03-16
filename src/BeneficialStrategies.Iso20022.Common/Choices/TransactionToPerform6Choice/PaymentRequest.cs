// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform6Choice
{
    /// <summary>
    /// Payment Request.
    /// </summary>
    [DisplayName("Payment Request")]
    public partial record PaymentRequest : TransactionToPerform6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PmtReq")]
        public required PaymentRequest6 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
