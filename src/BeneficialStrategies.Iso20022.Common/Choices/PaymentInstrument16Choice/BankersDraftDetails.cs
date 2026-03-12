// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument16Choice
{
    /// <summary>
    /// Settlement instructions for a payment by draft.
    /// </summary>
    [IsoId("_MgQvZRdKEeK5g-3oYI0_9Q")]
    [DisplayName("Bankers Draft Details")]
    public partial record BankersDraftDetails : PaymentInstrument16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Party to which a cheque is made payable.
        /// </summary>
        [IsoId("_QbdK-tp-Ed-ak6NoX_4Aeg_-2038541815")]
        [DisplayName("Payee Identification")]
        [IsoXmlTag("PyeeId")]
        public required NameAndAddress5 PayeeIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
