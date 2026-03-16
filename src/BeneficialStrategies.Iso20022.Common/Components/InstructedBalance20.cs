// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructed Balance20.
/// </summary>
[IsoId("_kbPEPYVQEe-oeNhl-Tk6YQ")]
[DisplayName("Instructed Balance20")]
public record InstructedBalance20
{
    /// <summary>
    /// Option Details.
    /// </summary>
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption21> OptionDetails { get; init; } = [];

    /// <summary>
    /// Total Accepted Instruction Balance.
    /// </summary>
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat10? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Total Cancelled Instruction Balance.
    /// </summary>
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat10? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Total Instructed Balance.
    /// </summary>
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat11Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Total Pending Instruction Balance.
    /// </summary>
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat10? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Total Protect Instruction Balance.
    /// </summary>
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat10? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Total Rejected Instruction Balance.
    /// </summary>
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat10? TotalRejectedInstructionBalance { get; init; }
}
