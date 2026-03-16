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
[IsoId("_I-cP8xn1EeyroI8qKgB7Mg")]
[DisplayName("Instructed Balance")]
public record InstructedBalance16
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_JT5iERn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat11Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_JT5iExn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat10? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_JT5iFRn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat10? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_JT5iFxn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat10? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_JT5iGRn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat10? TotalRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_JT5iGxn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat10? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_JT5iHRn1EeyroI8qKgB7Mg")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public InstructedCorporateActionOption17? OptionDetails { get; init; }
}
