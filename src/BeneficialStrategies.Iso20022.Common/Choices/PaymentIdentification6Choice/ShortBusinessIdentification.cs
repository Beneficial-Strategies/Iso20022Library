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
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification6Choice
{
    /// <summary>
    /// Business identification of the payment instruction given by the clearing agent.
    /// </summary>
    [IsoId("_Aghbl24-EeiU9cctagi5ow")]
    [DisplayName("Short Business Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ShortBusinessIdentification : PaymentIdentification6Choice_
    #else
    public partial class ShortBusinessIdentification : PaymentIdentification6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ShortBusinessIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ShortBusinessIdentification( System.String reqTransactionIdentification,System.DateOnly reqInterBankSettlementDate,BranchAndFinancialInstitutionIdentification6 reqInstructingAgent )
        {
            TransactionIdentification = reqTransactionIdentification;
            InterBankSettlementDate = reqInterBankSettlementDate;
            InstructingAgent = reqInstructingAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
        /// </summary>
        [IsoId("_A08MYW4-EeiU9cctagi5ow")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text TransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransactionIdentification { get; init; } 
        #else
        public System.String TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_A08MY24-EeiU9cctagi5ow")]
        [DisplayName("Inter Bank Settlement Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrBkSttlmDt")]
        #endif
        [IsoXmlTag("IntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate InterBankSettlementDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly InterBankSettlementDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly InterBankSettlementDate { get; init; } 
        #else
        public System.DateOnly InterBankSettlementDate { get; set; } 
        #endif
        
        /// <summary>
        /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_A08MZW4-EeiU9cctagi5ow")]
        [DisplayName("Instructing Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstgAgt")]
        #endif
        [IsoXmlTag("InstgAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
