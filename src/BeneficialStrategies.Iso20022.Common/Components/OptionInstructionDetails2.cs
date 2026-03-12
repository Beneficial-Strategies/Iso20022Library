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
[IsoId("_nG9pcf0jEeiKOe8GCUL1Lg")]
[DisplayName("Option Instruction Details")]
public partial record OptionInstructionDetails2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_ntpO8f0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_ntpO8_0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_ntpO9f0jEeiKOe8GCUL1Lg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    
    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_ntpO9_0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; } 
    
    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_ntpO-f0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; } 
    
    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_ntpO-_0jEeiKOe8GCUL1Lg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; } 
    
    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_ntpO_f0jEeiKOe8GCUL1Lg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; } 
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_ntpO__0jEeiKOe8GCUL1Lg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat57Choice_? BidPrice { get; init; } 
    
    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_ntpPAf0jEeiKOe8GCUL1Lg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_ntpPA_0jEeiKOe8GCUL1Lg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoRestrictedFINMax15Text? CustomerReference { get; init; } 
    
    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_ntpPBf0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; } 
    
    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_ntpPB_0jEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus36Choice_ InstructionStatus { get; init; } 
    
    
    #nullable disable
    
}
