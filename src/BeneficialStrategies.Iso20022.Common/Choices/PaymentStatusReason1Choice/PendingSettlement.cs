// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Reason why the payment status is pending (settlement).
    /// </summary>
    [IsoId("_QWOzudEdEei798TPbKJMuw")]
    [DisplayName("Pending Settlement")]
    public record PendingSettlement : PaymentStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
        /// </summary>
        [IsoXmlTag("PdgSttlm")]
        public required PendingSettlement2Code Value { get; init; }
    }
}
