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
[IsoId("_pf87HTi7Eeydid5dcNPKvg")]
[DisplayName("Option Instruction Details")]
public record OptionInstructionDetails8
{
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_pf87Hzi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_pf87ITi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_pf87Izi7Eeydid5dcNPKvg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }

    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_pf87JTi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity36Choice_ InstructionQuantity { get; init; }

    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_pf87Jzi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_pf87KTi7Eeydid5dcNPKvg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_pf87Kzi7Eeydid5dcNPKvg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_pf87LTi7Eeydid5dcNPKvg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat57Choice_? BidPrice { get; init; }

    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_pf87Lzi7Eeydid5dcNPKvg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity36Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_pf87MTi7Eeydid5dcNPKvg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoRestrictedFINMax50Text? CustomerReference { get; init; }

    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_pf87Mzi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_pf87NTi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus48Choice_ InstructionStatus { get; init; }
}
