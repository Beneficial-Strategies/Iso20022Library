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
[IsoId("_pf4pozi7Eeydid5dcNPKvg")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption18
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_pf4ppTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_pf4prTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption36Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_pf4ptTi7Eeydid5dcNPKvg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat14Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_pf4pvTi7Eeydid5dcNPKvg")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_pf4pxTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat13? OptionAcceptedInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_pf4pxzi7Eeydid5dcNPKvg")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat13? OptionCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_pf4pyTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat13? OptionPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_pf4pyzi7Eeydid5dcNPKvg")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat13? OptionRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_pf4pzTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat13? OptionProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_pf4pzzi7Eeydid5dcNPKvg")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines4 EventDeadlines { get; init; }

    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_pf4p0Ti7Eeydid5dcNPKvg")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public OptionInstructionDetails8? OptionInstructionDetails { get; init; }
}
