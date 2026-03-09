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
namespace BeneficialStrategies.Iso20022.Choices.CorrectiveTransaction4Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the corrective payment initiation.
    /// </summary>
    [IsoId("_3rWFwXuSEeivKIBRHeTQRQ")]
    [DisplayName("Initiation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Initiation : CorrectiveTransaction4Choice_
    #else
    public partial class Initiation : CorrectiveTransaction4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Initiation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Initiation( ActiveOrHistoricCurrencyAndAmount reqInstructedAmount )
        {
            InstructedAmount = reqInstructedAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide corrective information for the group header of the message under investigation.
        /// </summary>
        [IsoId("_33nAJXuSEeivKIBRHeTQRQ")]
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
        /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
        /// </summary>
        [IsoId("_33nAJ3uSEeivKIBRHeTQRQ")]
        [DisplayName("Payment Information Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtInfId")]
        #endif
        [IsoXmlTag("PmtInfId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? PaymentInformationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PaymentInformationIdentification { get; init; } 
        #else
        public System.String? PaymentInformationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
        /// </summary>
        [IsoId("_33nAKXuSEeivKIBRHeTQRQ")]
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
        [IsoId("_33nAK3uSEeivKIBRHeTQRQ")]
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
        /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_1nySkHuSEeivKIBRHeTQRQ")]
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
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
        /// </summary>
        [IsoId("_33nALXuSEeivKIBRHeTQRQ")]
        [DisplayName("Instructed Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstdAmt")]
        #endif
        [IsoXmlTag("InstdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date or date time at which the initiating party requests the clearing agent to process the payment. 
        /// Usage: This is the date or date time on which the debtor&apos;s account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
        /// </summary>
        [IsoId("_33nAL3uSEeivKIBRHeTQRQ")]
        [DisplayName("Requested Execution Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ReqdExctnDt")]
        #endif
        [IsoXmlTag("ReqdExctnDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
        #else
        public DateAndDateTime2Choice_? RequestedExecutionDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date at which the creditor requests the amount of money to be collected from the debtor.
        /// </summary>
        [IsoId("_33nAMXuSEeivKIBRHeTQRQ")]
        [DisplayName("Requested Collection Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ReqdColltnDt")]
        #endif
        [IsoXmlTag("ReqdColltnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? RequestedCollectionDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? RequestedCollectionDate { get; init; } 
        #else
        public System.DateOnly? RequestedCollectionDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
