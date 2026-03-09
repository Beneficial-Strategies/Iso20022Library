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
namespace BeneficialStrategies.Iso20022.Choices.CorrectiveTransaction5Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the corrective interbank payment transaction.
    /// </summary>
    [IsoId("_tP3Q49izEeq5MfBBxQig1Q")]
    [DisplayName("Interbank")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Interbank : CorrectiveTransaction5Choice_
    #else
    public partial class Interbank : CorrectiveTransaction5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Interbank instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Interbank( ActiveOrHistoricCurrencyAndAmount reqInterbankSettlementAmount,System.DateOnly reqInterbankSettlementDate )
        {
            InterbankSettlementAmount = reqInterbankSettlementAmount;
            InterbankSettlementDate = reqInterbankSettlementDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide corrective information for the group header of the message under investigation.
        /// </summary>
        [IsoId("_tRlvM9izEeq5MfBBxQig1Q")]
        [DisplayName("Group Header")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GrpHdr")]
        #endif
        [IsoXmlTag("GrpHdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CorrectiveGroupInformation1? GroupHeader { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CorrectiveGroupInformation1? GroupHeader { get; init; } 
        #else
        public CorrectiveGroupInformation1? GroupHeader { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
        /// </summary>
        [IsoId("_tRlvNdizEeq5MfBBxQig1Q")]
        [DisplayName("Instruction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrId")]
        #endif
        [IsoXmlTag("InstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? InstructionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? InstructionIdentification { get; init; } 
        #else
        public System.String? InstructionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
        /// </summary>
        [IsoId("_tRlvN9izEeq5MfBBxQig1Q")]
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
        
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
        /// </summary>
        [IsoId("_tRlvOdizEeq5MfBBxQig1Q")]
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
        [IsoId("_tRlvO9izEeq5MfBBxQig1Q")]
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
        [IsoId("_tRlvPdizEeq5MfBBxQig1Q")]
        [DisplayName("Interbank Settlement Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrBkSttlmAmt")]
        #endif
        [IsoXmlTag("IntrBkSttlmAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount InterbankSettlementAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount InterbankSettlementAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount InterbankSettlementAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount InterbankSettlementAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_tRlvP9izEeq5MfBBxQig1Q")]
        [DisplayName("Interbank Settlement Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrBkSttlmDt")]
        #endif
        [IsoXmlTag("IntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate InterbankSettlementDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly InterbankSettlementDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly InterbankSettlementDate { get; init; } 
        #else
        public System.DateOnly InterbankSettlementDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
