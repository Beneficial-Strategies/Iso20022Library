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
[IsoId("_3cJXT-6KEeqc-LCjwLsUVg")]
[DisplayName("Option Instruction Details")]
public record OptionInstructionDetails5
{
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_4FWsMe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_4FWsM-6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_4FWsNe6KEeqc-LCjwLsUVg")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }

    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_4FWsN-6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity1Choice_ InstructionQuantity { get; init; }

    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_4FWsOe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_4FWsO-6KEeqc-LCjwLsUVg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_4FWsPe6KEeqc-LCjwLsUVg")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_4FWsP-6KEeqc-LCjwLsUVg")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat45Choice_? BidPrice { get; init; }

    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_4FWsQe6KEeqc-LCjwLsUVg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_4FWsQ-6KEeqc-LCjwLsUVg")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReference { get; init; }

    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_4FWsRe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_4FWsR-6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus41Choice_ InstructionStatus { get; init; }
}
