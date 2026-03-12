// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Reason why the payment status is cancelled.
    /// </summary>
    [IsoId("_QWOzs9EdEei798TPbKJMuw")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : PaymentStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
