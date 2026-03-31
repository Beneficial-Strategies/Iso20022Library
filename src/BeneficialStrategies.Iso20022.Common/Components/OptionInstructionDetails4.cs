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
[IsoId("_DHEJsRzjEeqZpc4TWC-Ksg")]
[DisplayName("Option Instruction Details")]
public record OptionInstructionDetails4
{
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_DdiI8RzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_DdiI8xzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_DdiI9RzjEeqZpc4TWC-Ksg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }

    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_DdiI9xzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; }

    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_DdiI-RzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_DdiI-xzjEeqZpc4TWC-Ksg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_DdiI_RzjEeqZpc4TWC-Ksg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_DdiI_xzjEeqZpc4TWC-Ksg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat57Choice_? BidPrice { get; init; }

    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_DdiJARzjEeqZpc4TWC-Ksg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_DdiJAxzjEeqZpc4TWC-Ksg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
    [StringLength(maximumLength: 30, MinimumLength = 1)]
    public IsoRestrictedFINMax30Text? CustomerReference { get; init; }

    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_DdiJBRzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_DdiJBxzjEeqZpc4TWC-Ksg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus36Choice_ InstructionStatus { get; init; }
}
