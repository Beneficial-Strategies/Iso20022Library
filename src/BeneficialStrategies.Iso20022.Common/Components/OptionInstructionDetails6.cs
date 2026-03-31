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
[IsoId("_pUH1MR9QEeuFz_FaCzCLgQ")]
[DisplayName("Option Instruction Details")]
public record OptionInstructionDetails6
{
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    [IsoId("_pUH1Mx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; }

    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    [IsoId("_pUH1NR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Sequence Number")]
    [IsoXmlTag("InstrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_pUH1Nx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Protect Indicator")]
    [IsoXmlTag("PrtctInd")]
    public ProtectTransactionType2Code? ProtectIndicator { get; init; }

    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    [IsoId("_pUH1OR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public required FinancialInstrumentQuantity15Choice_ InstructionQuantity { get; init; }

    /// <summary>
    /// Date of the instruction.
    /// </summary>
    [IsoId("_pUH1Ox9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Date")]
    [IsoXmlTag("InstrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InstructionDate { get; init; }

    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    [IsoId("_pUH1PR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    [IsoId("_pUH1Px9QEeuFz_FaCzCLgQ")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CoverProtectDate { get; init; }

    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_pUH1QR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat57Choice_? BidPrice { get; init; }

    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    [IsoId("_pUH1Qx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    [IsoId("_pUH1RR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
    [StringLength(maximumLength: 30, MinimumLength = 1)]
    public IsoRestrictedFINMax30Text? CustomerReference { get; init; }

    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    [IsoId("_pUH1Rx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Narrative")]
    [IsoXmlTag("InstrNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; }

    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    [IsoId("_pUH1SR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionProcessingStatus43Choice_ InstructionStatus { get; init; }
}
