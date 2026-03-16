// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Reason why the payment status is pending (failing settlement).
    /// </summary>
    [IsoId("_Ny9Dx5lPEee-Zps0fZQaFQ")]
    [DisplayName("Pending Failing Settlement")]
    public record PendingFailingSettlement : PaymentStatusReasonCode7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
        /// </summary>
        [IsoXmlTag("PdgFlngSttlm")]
        public required PendingFailingSettlement1Code Value { get; init; }
    }
}
