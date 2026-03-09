// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions information received for a given option.
/// </summary>
[IsoId("_Jo6I7xn1EeyroI8qKgB7Mg")]
[DisplayName("Option Instruction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionInstructionDetails7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionInstructionDetails7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionInstructionDetails7( System.String reqInstructionIdentification,FinancialInstrumentQuantity33Choice_ reqInstructionQuantity,System.DateOnly reqInstructionDate,InstructionProcessingStatus47Choice_ reqInstructionStatus )
    {
        InstructionIdentification = reqInstructionIdentification;
        InstructionQuantity = reqInstructionQuantity;
        InstructionDate = reqInstructionDate;
        InstructionStatus = reqInstructionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_J-0HURn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructionIdentification { get; init; } 
    #else
    public System.String InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_J-0HUxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrSeqNb")]
    #endif
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionSequenceNumber { get; init; } 
    #else
    public System.String? InstructionSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_J-0HVRn1EeyroI8qKgB7Mg")]
    [DisplayName("Protect Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctInd")]
    #endif
    [IsoXmlTag("PrtctInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    #else
    public ProtectTransactionType2Code? ProtectIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_J-0HVxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrQty")]
    #endif
    [IsoXmlTag("InstrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity33Choice_ InstructionQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity33Choice_ InstructionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_ InstructionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_ InstructionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_J-0HWRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDt")]
    #endif
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate InstructionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly InstructionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly InstructionDate { get; init; } 
    #else
    public System.DateOnly InstructionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_J-0HWxn1EeyroI8qKgB7Mg")]
    [DisplayName("Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDt")]
    #endif
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ProtectDate { get; init; } 
    #else
    public System.DateOnly? ProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_J-0HXRn1EeyroI8qKgB7Mg")]
    [DisplayName("Cover Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverPrtctDt")]
    #endif
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CoverProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CoverProtectDate { get; init; } 
    #else
    public System.DateOnly? CoverProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_J-0HXxn1EeyroI8qKgB7Mg")]
    [DisplayName("Bid Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidPric")]
    #endif
    [IsoXmlTag("BidPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat45Choice_? BidPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat45Choice_? BidPrice { get; init; } 
    #else
    public PriceFormat45Choice_? BidPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_J-0HYRn1EeyroI8qKgB7Mg")]
    [DisplayName("Conditional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlQty")]
    #endif
    [IsoXmlTag("CondlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_J-0HYxn1EeyroI8qKgB7Mg")]
    [DisplayName("Customer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRef")]
    #endif
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? CustomerReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReference { get; init; } 
    #else
    public System.String? CustomerReference { get; set; } 
    #endif
    
    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_J-0HZRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrNrrtv")]
    #endif
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionNarrative { get; init; } 
    #else
    public System.String? InstructionNarrative { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_J-0HZxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrSts")]
    #endif
    [IsoXmlTag("InstrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionProcessingStatus47Choice_ InstructionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionProcessingStatus47Choice_ InstructionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionProcessingStatus47Choice_ InstructionStatus { get; init; } 
    #else
    public InstructionProcessingStatus47Choice_ InstructionStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
