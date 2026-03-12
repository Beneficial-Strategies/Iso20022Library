// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Defines the reason that has been used by the system to reject the transaction.
    /// </summary>
    [IsoId("_QWOzu9EdEei798TPbKJMuw")]
    [DisplayName("Proprietary Rejection")]
    public partial record ProprietaryRejection : PaymentStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Defines the reason why the system has rejected the transaction.
        /// </summary>
        [IsoId("_hU5UQdEdEei798TPbKJMuw")]
        [DisplayName("Proprietary Status Reason")]
        [IsoXmlTag("PrtryStsRsn")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; } 
        
        /// <summary>
        /// Provides detailed information about the reason why the  system has rejected the transaction.
        /// </summary>
        [IsoId("_hU5UQ9EdEei798TPbKJMuw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public required IsoMax256Text Reason { get; init; } 
        
        
        #nullable disable
        
    }
}
