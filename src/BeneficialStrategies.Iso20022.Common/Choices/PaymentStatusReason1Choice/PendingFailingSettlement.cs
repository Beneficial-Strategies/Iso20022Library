// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Reason why the payment status is pending (failing settlement).
    /// </summary>
    [IsoId("_QWOzt9EdEei798TPbKJMuw")]
    [DisplayName("Pending Failing Settlement")]
    public partial record PendingFailingSettlement : PaymentStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
        /// </summary>
        [IsoXmlTag("PdgFlngSttlm")]
        public required PendingFailingSettlement1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
