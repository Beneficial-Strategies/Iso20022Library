// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_JT5iHxn1EeyroI8qKgB7Mg")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption17
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_Jo6IwRn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_Jo6IyRn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption30Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_Jo6I0Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat11Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_Jo6I2Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_Jo6I4Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I4xn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_Jo6I5Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I5xn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_Jo6I6Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_Jo6I6xn1EeyroI8qKgB7Mg")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; }

    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_Jo6I7Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public ValueList<OptionInstructionDetails7> OptionInstructionDetails { get; init; } = [];
}
