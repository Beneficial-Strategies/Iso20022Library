// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform2Choice
{
    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [IsoId("_ro9DxQxrEeqdx6buGpCCQw")]
    [DisplayName("Reversal Request")]
    public partial record ReversalRequest : TransactionToPerform2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Original transaction to reverse.
        /// </summary>
        [IsoId("_SlixIQ1REeqjM-rxn3HuXQ")]
        [DisplayName("Original Payment Transaction")]
        [IsoXmlTag("OrgnlPmtTx")]
        public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; } 
        
        /// <summary>
        /// Reason for this reversal.
        /// </summary>
        [IsoId("_SlixIw1REeqjM-rxn3HuXQ")]
        [DisplayName("Reversal Reason")]
        [IsoXmlTag("RvslRsn")]
        public required ReversalReason1Code ReversalReason { get; init; } 
        
        /// <summary>
        /// Amount to reverse (total or partial).
        /// </summary>
        [IsoId("_SlixJQ1REeqjM-rxn3HuXQ")]
        [DisplayName("Reversed Amount")]
        [IsoXmlTag("RvsdAmt")]
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
        
        /// <summary>
        /// Specific Customer Order linked with the reversal.
        /// </summary>
        [IsoId("_SlixJw1REeqjM-rxn3HuXQ")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; } 
        
        
        #nullable disable
        
    }
}
