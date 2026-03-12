// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions information received for a given option.
/// </summary>
[IsoId("_Jo6I7xn1EeyroI8qKgB7Mg")]
[DisplayName("Option Instruction Details")]
public partial record OptionInstructionDetails7
{
    #nullable enable
    
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_J-0HURn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_J-0HUxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_J-0HVRn1EeyroI8qKgB7Mg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    
    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_J-0HVxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity33Choice_ InstructionQuantity { get; init; } 
    
    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_J-0HWRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; } 
    
    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_J-0HWxn1EeyroI8qKgB7Mg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; } 
    
    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_J-0HXRn1EeyroI8qKgB7Mg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; } 
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_J-0HXxn1EeyroI8qKgB7Mg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat45Choice_? BidPrice { get; init; } 
    
    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_J-0HYRn1EeyroI8qKgB7Mg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_J-0HYxn1EeyroI8qKgB7Mg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? CustomerReference { get; init; } 
    
    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_J-0HZRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionNarrative { get; init; } 
    
    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_J-0HZxn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus47Choice_ InstructionStatus { get; init; } 
    
    
    #nullable disable
    
}
