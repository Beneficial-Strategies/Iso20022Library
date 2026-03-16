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
[IsoId("_D3XZp_fQEeiNZp_PtLohLw")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption11
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_D3XZqffQEeiNZp_PtLohLw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_D3XZsffQEeiNZp_PtLohLw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption23Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_D3XZuffQEeiNZp_PtLohLw")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat7Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_D3XZwffQEeiNZp_PtLohLw")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_D3XZyffQEeiNZp_PtLohLw")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat9? OptionAcceptedInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_D3XZy_fQEeiNZp_PtLohLw")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat9? OptionCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_D3XZzffQEeiNZp_PtLohLw")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat9? OptionPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_D3XZz_fQEeiNZp_PtLohLw")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat9? OptionRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_D3XZ0ffQEeiNZp_PtLohLw")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat9? OptionProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_D3XZ0_fQEeiNZp_PtLohLw")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines4 EventDeadlines { get; init; }

    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_D3XZ1ffQEeiNZp_PtLohLw")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public OptionInstructionDetails2? OptionInstructionDetails { get; init; }
}
