// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option Instruction Details12.
/// </summary>
[IsoId("_j2FabZt3Ee-wQIOX0djF2w")]
[DisplayName("Option Instruction Details12")]
public record OptionInstructionDetails12
{
    /// <summary>
    /// Bid Price.
    /// </summary>
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat82Choice_? BidPrice { get; init; }

    /// <summary>
    /// Conditional Quantity.
    /// </summary>
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity36Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Cover Protect Date.
    /// </summary>
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Customer Reference.
    /// </summary>
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public IsoRestrictedFINMax50Text? CustomerReference { get; init; }

    /// <summary>
    /// Instruction Date.
    /// </summary>
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Instruction Narrative.
    /// </summary>
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Instruction Quantity.
    /// </summary>
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity36Choice_ InstructionQuantity { get; init; }

    /// <summary>
    /// Instruction Sequence Number.
    /// </summary>
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Instruction Status.
    /// </summary>
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus57Choice_ InstructionStatus { get; init; }

    /// <summary>
    /// Protect Date.
    /// </summary>
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Protect Indicator.
    /// </summary>
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }
}
