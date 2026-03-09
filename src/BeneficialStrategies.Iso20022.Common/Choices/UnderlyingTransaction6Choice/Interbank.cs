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
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction6Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the original interbank payment transaction.
    /// </summary>
    [IsoId("_xLWgk8loEem0vqvvoqYsqQ")]
    [DisplayName("Interbank")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Interbank : UnderlyingTransaction6Choice_
    #else
    public partial class Interbank : UnderlyingTransaction6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Interbank instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Interbank( ActiveOrHistoricCurrencyAndAmount reqOriginalInterbankSettlementAmount,System.DateOnly reqOriginalInterbankSettlementDate )
        {
            OriginalInterbankSettlementAmount = reqOriginalInterbankSettlementAmount;
            OriginalInterbankSettlementDate = reqOriginalInterbankSettlementDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_xXRcs8loEem0vqvvoqYsqQ")]
        [DisplayName("Original Group Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlGrpInf")]
        #endif
        [IsoXmlTag("OrgnlGrpInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
        #else
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
        /// </summary>
        [IsoId("_xXRctcloEem0vqvvoqYsqQ")]
        [DisplayName("Original Instruction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlInstrId")]
        #endif
        [IsoXmlTag("OrgnlInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalInstructionIdentification { get; init; } 
        #else
        public System.String? OriginalInstructionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
        /// </summary>
        [IsoId("_xXRct8loEem0vqvvoqYsqQ")]
        [DisplayName("Original End To End Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlEndToEndId")]
        #endif
        [IsoXmlTag("OrgnlEndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalEndToEndIdentification { get; init; } 
        #else
        public System.String? OriginalEndToEndIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
        /// </summary>
        [IsoId("_xXRcucloEem0vqvvoqYsqQ")]
        [DisplayName("Original Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlTxId")]
        #endif
        [IsoXmlTag("OrgnlTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalTransactionIdentification { get; init; } 
        #else
        public System.String? OriginalTransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_xXRcu8loEem0vqvvoqYsqQ")]
        [DisplayName("Original UETR")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlUETR")]
        #endif
        [IsoXmlTag("OrgnlUETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalUETR { get; init; } 
        #else
        public System.String? OriginalUETR { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
        /// </summary>
        [IsoId("_xXRcvcloEem0vqvvoqYsqQ")]
        [DisplayName("Original Interbank Settlement Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlIntrBkSttlmAmt")]
        #endif
        [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_xXRcv8loEem0vqvvoqYsqQ")]
        [DisplayName("Original Interbank Settlement Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlIntrBkSttlmDt")]
        #endif
        [IsoXmlTag("OrgnlIntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate OriginalInterbankSettlementDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly OriginalInterbankSettlementDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly OriginalInterbankSettlementDate { get; init; } 
        #else
        public System.DateOnly OriginalInterbankSettlementDate { get; set; } 
        #endif
        
        /// <summary>
        /// Key elements used to identify the original transaction that is being referred to.
        /// </summary>
        [IsoId("_xXRcwcloEem0vqvvoqYsqQ")]
        [DisplayName("Original Transaction Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlTxRef")]
        #endif
        [IsoXmlTag("OrgnlTxRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OriginalTransactionReference31? OriginalTransactionReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OriginalTransactionReference31? OriginalTransactionReference { get; init; } 
        #else
        public OriginalTransactionReference31? OriginalTransactionReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
