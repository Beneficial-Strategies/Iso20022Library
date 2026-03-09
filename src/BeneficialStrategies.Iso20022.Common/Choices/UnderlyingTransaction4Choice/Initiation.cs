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
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction4Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the original payment initiation.
    /// </summary>
    [IsoId("_hbH5EYKZEee7hrXqLO3yQg")]
    [DisplayName("Initiation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Initiation : UnderlyingTransaction4Choice_
    #else
    public partial class Initiation : UnderlyingTransaction4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Initiation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Initiation( ActiveOrHistoricCurrencyAndAmount reqOriginalInstructedAmount )
        {
            OriginalInstructedAmount = reqOriginalInstructedAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_8NjBda6FEeexrtTFgmVD3Q")]
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
        /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
        /// </summary>
        [IsoId("_8NjBd66FEeexrtTFgmVD3Q")]
        [DisplayName("Original Payment Information Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlPmtInfId")]
        #endif
        [IsoXmlTag("OrgnlPmtInfId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalPaymentInformationIdentification { get; init; } 
        #else
        public System.String? OriginalPaymentInformationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
        /// </summary>
        [IsoId("_8NjBea6FEeexrtTFgmVD3Q")]
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
        [IsoId("_8NjBe66FEeexrtTFgmVD3Q")]
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
        /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
        /// </summary>
        [IsoId("_8NjBfa6FEeexrtTFgmVD3Q")]
        [DisplayName("Original Instructed Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlInstdAmt")]
        #endif
        [IsoXmlTag("OrgnlInstdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor&apos;s account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
        /// </summary>
        [IsoId("_8NjBf66FEeexrtTFgmVD3Q")]
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
        [IsoId("_8NjBga6FEeexrtTFgmVD3Q")]
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
        
        /// <summary>
        /// Key elements used to identify the original transaction that is being referred to.
        /// </summary>
        [IsoId("_qYAUEbPnEeeppqgHuc69jg")]
        [DisplayName("Original Transaction Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlTxRef")]
        #endif
        [IsoXmlTag("OrgnlTxRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OriginalTransactionReference27? OriginalTransactionReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OriginalTransactionReference27? OriginalTransactionReference { get; init; } 
        #else
        public OriginalTransactionReference27? OriginalTransactionReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
