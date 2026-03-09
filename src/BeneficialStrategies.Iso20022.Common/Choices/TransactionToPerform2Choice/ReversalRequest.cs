// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform2Choice
{
    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [IsoId("_ro9DxQxrEeqdx6buGpCCQw")]
    [DisplayName("Reversal Request")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ReversalRequest : TransactionToPerform2Choice_
    #else
    public partial class ReversalRequest : TransactionToPerform2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ReversalRequest instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ReversalRequest( ReversalReason1Code reqReversalReason )
        {
            ReversalReason = reqReversalReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Original transaction to reverse.
        /// </summary>
        [IsoId("_SlixIQ1REeqjM-rxn3HuXQ")]
        [DisplayName("Original Payment Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlPmtTx")]
        #endif
        [IsoXmlTag("OrgnlPmtTx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; } 
        #else
        public CardPaymentTransaction100? OriginalPaymentTransaction { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for this reversal.
        /// </summary>
        [IsoId("_SlixIw1REeqjM-rxn3HuXQ")]
        [DisplayName("Reversal Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RvslRsn")]
        #endif
        [IsoXmlTag("RvslRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReversalReason1Code ReversalReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReversalReason1Code ReversalReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReversalReason1Code ReversalReason { get; init; } 
        #else
        public ReversalReason1Code ReversalReason { get; set; } 
        #endif
        
        /// <summary>
        /// Amount to reverse (total or partial).
        /// </summary>
        [IsoId("_SlixJQ1REeqjM-rxn3HuXQ")]
        [DisplayName("Reversed Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RvsdAmt")]
        #endif
        [IsoXmlTag("RvsdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
        #else
        public ImpliedCurrencyAndAmount? ReversedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Specific Customer Order linked with the reversal.
        /// </summary>
        [IsoId("_SlixJw1REeqjM-rxn3HuXQ")]
        [DisplayName("Customer Order")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CstmrOrdr")]
        #endif
        [IsoXmlTag("CstmrOrdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CustomerOrder1? CustomerOrder { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CustomerOrder1? CustomerOrder { get; init; } 
        #else
        public CustomerOrder1? CustomerOrder { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
