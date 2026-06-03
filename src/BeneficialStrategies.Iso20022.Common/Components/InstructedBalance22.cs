// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_HiYaca8wEfCx2aBifPEdRg")]
[DisplayName("Instructed Balance22")]
public record InstructedBalance22
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_HpB1Aa8wEfCx2aBifPEdRg")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat11Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of all accepted instructions for given day. Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_HpB1A68wEfCx2aBifPEdRg")]
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat10? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_HpB1Ba8wEfCx2aBifPEdRg")]
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat10? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status. It includes cancel pending instructions.
    /// </summary>
    [IsoId("_HpB1B68wEfCx2aBifPEdRg")]
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat10? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_HpB1Ca8wEfCx2aBifPEdRg")]
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat10? TotalRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_HpB1C68wEfCx2aBifPEdRg")]
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat10? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_HpB1Da8wEfCx2aBifPEdRg")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption23> OptionDetails { get; init; } = [];
}
