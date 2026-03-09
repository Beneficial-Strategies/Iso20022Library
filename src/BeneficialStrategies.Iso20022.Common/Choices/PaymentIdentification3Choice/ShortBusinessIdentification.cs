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
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification3Choice
{
    /// <summary>
    /// Business identification of the payment instruction given by the clearing agent.
    /// </summary>
    [IsoId("_Rbhg09p-Ed-ak6NoX_4Aeg_-1132471681")]
    [DisplayName("Short Business Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ShortBusinessIdentification : PaymentIdentification3Choice_
    #else
    public partial class ShortBusinessIdentification : PaymentIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ShortBusinessIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ShortBusinessIdentification( System.String reqPaymentInstructionReference,System.DateOnly reqInterbankValueDate,System.String reqInstructingAgentIdentification )
        {
            PaymentInstructionReference = reqPaymentInstructionReference;
            InterbankValueDate = reqInterbankValueDate;
            InstructingAgentIdentification = reqInstructingAgentIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
        /// </summary>
        [IsoId("_Pg5AJNp-Ed-ak6NoX_4Aeg_-2107642032")]
        [DisplayName("Payment Instruction Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtInstrRef")]
        #endif
        [IsoXmlTag("PmtInstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text PaymentInstructionReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String PaymentInstructionReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String PaymentInstructionReference { get; init; } 
        #else
        public System.String PaymentInstructionReference { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_Pg5AJdp-Ed-ak6NoX_4Aeg_-2106719051")]
        [DisplayName("Interbank Value Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrBkValDt")]
        #endif
        [IsoXmlTag("IntrBkValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate InterbankValueDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly InterbankValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly InterbankValueDate { get; init; } 
        #else
        public System.DateOnly InterbankValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// The identification of the instructing agent that transmitted the payment instruction.
        /// </summary>
        [IsoId("_Pg5AJtp-Ed-ak6NoX_4Aeg_-2106718120")]
        [DisplayName("Instructing Agent Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstgAgtId")]
        #endif
        [IsoXmlTag("InstgAgtId")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBICIdentifier InstructingAgentIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String InstructingAgentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String InstructingAgentIdentification { get; init; } 
        #else
        public System.String InstructingAgentIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
