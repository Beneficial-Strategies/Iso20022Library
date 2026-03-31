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
[IsoId("_DkdFFQVSEeqjd8n6wD9JVw")]
[DisplayName("Instructed Balance")]
public record InstructedBalance12
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_DkdFFwVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat7Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_DkdFGQVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_DkdFGwVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_DkdFHQVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_DkdFHwVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_DkdFIQVSEeqjd8n6wD9JVw")]
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_DkdFIwVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption13> OptionDetails { get; init; } = [];
}
