// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument27Choice
{
    /// <summary>
    /// Payment Card Details.
    /// </summary>
    [DisplayName("Payment Card Details")]
    public partial record PaymentCardDetails : PaymentInstrument27Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PmtCardDtls")]
        public required PaymentCard34 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
