// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Reason why the payment status is suspended.
    /// </summary>
    [IsoId("_Ny9DxZlPEee-Zps0fZQaFQ")]
    [DisplayName("Suspended")]
    public partial record Suspended : PaymentStatusReasonCode7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is suspended.
        /// </summary>
        [IsoXmlTag("Sspd")]
        public required SuspendedStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
