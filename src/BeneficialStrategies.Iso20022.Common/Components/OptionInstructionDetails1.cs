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
[IsoId("_BRD5oLtLEeilsanBGAzy4A")]
[DisplayName("Option Instruction Details")]
public partial record OptionInstructionDetails1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_s4C8oLtLEeilsanBGAzy4A")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_6sWaALtLEeilsanBGAzy4A")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_UrMhoLtMEeilsanBGAzy4A")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    
    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_esLXALtPEeilsanBGAzy4A")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity1Choice_ InstructionQuantity { get; init; } 
    
    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_GMuwILtQEeilsanBGAzy4A")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; } 
    
    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_O3p44LtQEeilsanBGAzy4A")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; } 
    
    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_nGnXQLtQEeilsanBGAzy4A")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; } 
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_u0r2MLtQEeilsanBGAzy4A")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat45Choice_? BidPrice { get; init; } 
    
    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_B8WDkLtREeilsanBGAzy4A")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_NV7yALtREeilsanBGAzy4A")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? CustomerReference { get; init; } 
    
    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_1ayLALtREeilsanBGAzy4A")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InstructionNarrative { get; init; } 
    
    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_kyVVkLtSEeilsanBGAzy4A")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus32Choice_ InstructionStatus { get; init; } 
    
    
    #nullable disable
    
}
