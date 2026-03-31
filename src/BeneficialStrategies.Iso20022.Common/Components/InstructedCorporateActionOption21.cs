// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructed Corporate Action Option21.
/// </summary>
[IsoId("_khmKj4VQEe-oeNhl-Tk6YQ")]
[DisplayName("Instructed Corporate Action Option21")]
public record InstructedCorporateActionOption21
{
    /// <summary>
    /// Default Action.
    /// </summary>
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction2Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Event Deadlines.
    /// </summary>
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; }

    /// <summary>
    /// Instructed Balance.
    /// </summary>
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat11Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Option Accepted Instructed Balance.
    /// </summary>
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat10? OptionAcceptedInstructedBalance { get; init; }

    /// <summary>
    /// Option Cancelled Instruction Balance.
    /// </summary>
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat10? OptionCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Option Instruction Details.
    /// </summary>
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public ValueList<OptionInstructionDetails11> OptionInstructionDetails { get; init; } = [];

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Option Pending Instruction Balance.
    /// </summary>
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat10? OptionPendingInstructionBalance { get; init; }

    /// <summary>
    /// Option Protect Instruction Balance.
    /// </summary>
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat10? OptionProtectInstructionBalance { get; init; }

    /// <summary>
    /// Option Rejected Instruction Balance.
    /// </summary>
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat10? OptionRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Option Returned Instructed Balance.
    /// </summary>
    [DisplayName("Option Returned Instructed Balance")]
    [IsoXmlTag("OptnRtrdInstdBal")]
    public SignedQuantityFormat10? OptionReturnedInstructedBalance { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption30Choice_ OptionType { get; init; }
}
