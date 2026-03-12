// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Reason why the payment status is pending (settlement).
    /// </summary>
    [IsoId("_Ny9DyZlPEee-Zps0fZQaFQ")]
    [DisplayName("Pending Settlement")]
    public partial record PendingSettlement : PaymentStatusReasonCode7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
        /// </summary>
        [IsoXmlTag("PdgSttlm")]
        public required PendingSettlement2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
