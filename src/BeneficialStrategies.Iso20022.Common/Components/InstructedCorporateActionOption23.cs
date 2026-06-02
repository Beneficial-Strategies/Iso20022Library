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
[IsoId("_HpCcEa8wEfCx2aBifPEdRg")]
[DisplayName("Instructed Corporate Action Option23")]
public record InstructedCorporateActionOption23
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_Hvsdsa8wEfCx2aBifPEdRg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_Hvsdua8wEfCx2aBifPEdRg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption30Choice OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_Hvsdwa8wEfCx2aBifPEdRg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat11Choice InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_Hvsdya8wEfCx2aBifPEdRg")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction2Choice? DefaultAction { get; init; }

    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_Hvsd0a8wEfCx2aBifPEdRg")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_HvtEwa8wEfCx2aBifPEdRg")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status for a given option. It includes cancel pending instructions.
    /// </summary>
    [IsoId("_HvtEw68wEfCx2aBifPEdRg")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_HvtExa8wEfCx2aBifPEdRg")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of returned instructions received for a given option.
    /// </summary>
    [IsoId("_HvtEx68wEfCx2aBifPEdRg")]
    [DisplayName("Option Returned Instructed Balance")]
    [IsoXmlTag("OptnRtrdInstdBal")]
    public SignedQuantityFormat10? OptionReturnedInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_HvtEya8wEfCx2aBifPEdRg")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_HvtEy68wEfCx2aBifPEdRg")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; }

    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_HvtEza8wEfCx2aBifPEdRg")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public ValueList<OptionInstructionDetails13> OptionInstructionDetails { get; init; } = [];
}
