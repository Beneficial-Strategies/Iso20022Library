// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Reason why the payment status is unmatched.
    /// </summary>
    [IsoId("_QWOzsdEdEei798TPbKJMuw")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : PaymentStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is unmatched.
        /// </summary>
        [IsoXmlTag("Umtchd")]
        public required UnmatchedStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
