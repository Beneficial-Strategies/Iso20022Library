// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions, initiated by the creditor, to debit a debtor&apos;s account in favour of the creditor.
/// </summary>
[IsoId("_W-O3YQ2mEeSNWNtJlXOAhg")]
[DisplayName("Direct Debit Instruction Details")]
public record DirectDebitInstructionDetails1
{
    /// <summary>
    /// Identification of the mandate for a direct debit instruction.
    /// </summary>
    [IsoId("_qUm2MA2mEeSNWNtJlXOAhg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <summary>
    /// Indicates whether the instruction is an automated direct debit instruction.
    /// Usage: Default value for AutomatedDirectDebitInstructionIndicator is false.
    /// </summary>
    [IsoId("_da9K4ISTEeacouu3s33q-Q")]
    [DisplayName("Automated Direct Debit Instruction Indicator")]
    [IsoXmlTag("AutomtdDrctDbtInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AutomatedDirectDebitInstructionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the direct debit instruction is transferable.
    /// Usage: Default value for DirectDebitTransferableIndicator is false.
    /// </summary>
    [IsoId("_M2KtcISUEeacouu3s33q-Q")]
    [DisplayName("Direct Debit Transferable Indicator")]
    [IsoXmlTag("DrctDbtTrfblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DirectDebitTransferableIndicator { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_uUo9IA2mEeSNWNtJlXOAhg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification125 Creditor { get; init; }

    /// <summary>
    /// Amount of the last debit made for the direct debit mandate.
    /// </summary>
    [IsoId("_K61hgA2nEeSNWNtJlXOAhg")]
    [DisplayName("Last Collection Currency Amount")]
    [IsoXmlTag("LastColltnCcyAmt")]
    public ActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; init; }

    /// <summary>
    /// Date on which the last debit for the direct debit mandate may be made.
    /// Usage: Not included if all limits to the validity of the direct debit mandate have already been specified or if there are no time limits on the validity of the direct debit.
    /// </summary>
    [IsoId("_2IhJIA2mEeSNWNtJlXOAhg")]
    [DisplayName("Last Collection Date")]
    [IsoXmlTag("LastColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastCollectionDate { get; init; }

    /// <summary>
    /// Provides further information about the status of a requested transaction schedule transfer.
    /// </summary>
    [IsoId("_RW8awOfNEea-bLUDhRZm-w")]
    [DisplayName("Other Details")]
    [IsoXmlTag("OthrDtls")]
    public TransferInstruction1? OtherDetails { get; init; }
}
