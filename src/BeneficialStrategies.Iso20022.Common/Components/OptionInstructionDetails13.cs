// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions information received for a given option.
/// </summary>
[IsoId("_HvtEz68wEfCx2aBifPEdRg")]
[DisplayName("Option Instruction Details13")]
public record OptionInstructionDetails13
{
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_H2bX0a8wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_H2bX068wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_H2bX1a8wEfCx2aBifPEdRg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }

    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_H2bX168wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity33Choice InstructionQuantity { get; init; }

    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_H2bX2a8wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_H2bX268wEfCx2aBifPEdRg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Date of the cover protect instruction.
    /// </summary>
    [IsoId("_H2bX3a8wEfCx2aBifPEdRg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_H2bX368wEfCx2aBifPEdRg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat74Choice? BidPrice { get; init; }

    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_H2bX4a8wEfCx2aBifPEdRg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity33Choice? ConditionalQuantity { get; init; }

    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_H2bX468wEfCx2aBifPEdRg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public IsoMax50Text? CustomerReference { get; init; }

    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_H2bX5a8wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    public IsoMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_H2bX568wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus62Choice InstructionStatus { get; init; }
}
