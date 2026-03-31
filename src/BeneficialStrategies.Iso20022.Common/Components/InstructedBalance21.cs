// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructed Balance21.
/// </summary>
[IsoId("_j2DlB5t3Ee-wQIOX0djF2w")]
[DisplayName("Instructed Balance21")]
public record InstructedBalance21
{
    /// <summary>
    /// Option Details.
    /// </summary>
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption22> OptionDetails { get; init; } = [];

    /// <summary>
    /// Total Accepted Instruction Balance.
    /// </summary>
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat13? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Total Cancelled Instruction Balance.
    /// </summary>
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat13? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Total Instructed Balance.
    /// </summary>
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat14Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Total Pending Instruction Balance.
    /// </summary>
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat13? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Total Protect Instruction Balance.
    /// </summary>
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat13? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Total Rejected Instruction Balance.
    /// </summary>
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat13? TotalRejectedInstructionBalance { get; init; }
}
