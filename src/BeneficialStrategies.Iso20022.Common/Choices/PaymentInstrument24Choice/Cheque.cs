// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument24Choice
{
    /// <summary>
    /// Indicates whether the payment is done via cheque.
    /// </summary>
    [IsoId("_Jmv4xZTBEemqYPWMBuVawg")]
    [DisplayName("Cheque")]
    public partial record Cheque : PaymentInstrument24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("Chq")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
