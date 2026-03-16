// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Direct Debit Instruction Details3.
/// </summary>
[IsoId("_zllRsTEyEe6g-ffJsqGiSA")]
[DisplayName("Direct Debit Instruction Details3")]
public record DirectDebitInstructionDetails3
{
    /// <summary>
    /// Automated Direct Debit Instruction Indicator.
    /// </summary>
    [DisplayName("Automated Direct Debit Instruction Indicator")]
    [IsoXmlTag("AutomtdDrctDbtInstrInd")]
    public IsoYesNoIndicator? AutomatedDirectDebitInstructionIndicator { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Direct Debit Transferable Indicator.
    /// </summary>
    [DisplayName("Direct Debit Transferable Indicator")]
    [IsoXmlTag("DrctDbtTrfblInd")]
    public IsoYesNoIndicator? DirectDebitTransferableIndicator { get; init; }

    /// <summary>
    /// Last Collection Currency Amount.
    /// </summary>
    [DisplayName("Last Collection Currency Amount")]
    [IsoXmlTag("LastColltnCcyAmt")]
    public ActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; init; }

    /// <summary>
    /// Last Collection Date.
    /// </summary>
    [DisplayName("Last Collection Date")]
    [IsoXmlTag("LastColltnDt")]
    public IsoISODate? LastCollectionDate { get; init; }

    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Other Details.
    /// </summary>
    [DisplayName("Other Details")]
    [IsoXmlTag("OthrDtls")]
    public ValueList<TransferInstruction1> OtherDetails { get; init; } = [];
}
