// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Reason why the payment status is cancelled.
    /// </summary>
    [IsoId("_QWOzs9EdEei798TPbKJMuw")]
    [DisplayName("Cancelled")]
    public record Cancelled : PaymentStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatusReason1Code Value { get; init; }
    }
}
