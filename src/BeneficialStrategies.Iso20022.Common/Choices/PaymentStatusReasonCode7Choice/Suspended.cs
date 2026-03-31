// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Reason why the payment status is suspended.
    /// </summary>
    [IsoId("_Ny9DxZlPEee-Zps0fZQaFQ")]
    [DisplayName("Suspended")]
    public record Suspended : PaymentStatusReasonCode7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is suspended.
        /// </summary>
        [IsoXmlTag("Sspd")]
        public required SuspendedStatusReason1Code Value { get; init; }
    }
}
