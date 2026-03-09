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
    [IsoId("_AghblW4-EeiU9cctagi5ow")]
    [DisplayName("Long Business Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record LongBusinessIdentification : PaymentIdentification6Choice_
    #else
    public partial class LongBusinessIdentification : PaymentIdentification6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a LongBusinessIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public LongBusinessIdentification( ImpliedCurrencyAndAmount reqInterBankSettlementAmount,System.DateOnly reqInterBankSettlementDate,BranchAndFinancialInstitutionIdentification6 reqInstructingAgent,BranchAndFinancialInstitutionIdentification6 reqInstructedAgent )
        {
            InterBankSettlementAmount = reqInterBankSettlementAmount;
            InterBankSettlementDate = reqInterBankSettlementDate;
            InstructingAgent = reqInstructingAgent;
            InstructedAgent = reqInstructedAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
        /// </summary>
        [IsoId("_AqNjEW4-EeiU9cctagi5ow")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransactionIdentification { get; init; } 
        #else
        public System.String? TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_0o9gEYkKEei-69PNFxn_Ew")]
        [DisplayName("UETR")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UETR")]
        #endif
        [IsoXmlTag("UETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoUUIDv4Identifier? UETR { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UETR { get; init; } 
        #else
        public System.String? UETR { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent.
        /// </summary>
        [IsoId("_AqNjE24-EeiU9cctagi5ow")]
        [DisplayName("Inter Bank Settlement Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrBkSttlmAmt")]
        #endif
        [IsoXmlTag("IntrBkSttlmAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ImpliedCurrencyAndAmount InterBankSettlementAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ImpliedCurrencyAndAmount InterBankSettlementAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ImpliedCurrencyAndAmount InterBankSettlementAmount { get; init; } 
        #else
        public ImpliedCurrencyAndAmount InterBankSettlementAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_AqNjFW4-EeiU9cctagi5ow")]
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
        /// Message type with which the instruction has been initiated.
        /// </summary>
        [IsoId("_AqNjF24-EeiU9cctagi5ow")]
        [DisplayName("Payment Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtMtd")]
        #endif
        [IsoXmlTag("PmtMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
        #else
        public PaymentOrigin1Choice_? PaymentMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_AqNjGW4-EeiU9cctagi5ow")]
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
        
        /// <summary>
        /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_AqNjG24-EeiU9cctagi5ow")]
        [DisplayName("Instructed Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstdAgt")]
        #endif
        [IsoXmlTag("InstdAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification6 InstructedAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification6 InstructedAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6 InstructedAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6 InstructedAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Optional qualifier providing additional system specific information about the entry.
        /// </summary>
        [IsoId("_AqNjHW4-EeiU9cctagi5ow")]
        [DisplayName("Entry Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NtryTp")]
        #endif
        [IsoXmlTag("NtryTp")]
        [IsoSimpleType(IsoSimpleType.EntryTypeIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoEntryTypeIdentifier? EntryType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EntryType { get; init; } 
        #else
        public System.String? EntryType { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
        /// </summary>
        [IsoId("_AqNjH24-EeiU9cctagi5ow")]
        [DisplayName("End To End Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EndToEndId")]
        #endif
        [IsoXmlTag("EndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? EndToEndIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EndToEndIdentification { get; init; } 
        #else
        public System.String? EndToEndIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
