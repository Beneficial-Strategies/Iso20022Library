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
[IsoId("_wSkDc-aqEemtTOaHuc_63w")]
[DisplayName("Instructed Balance")]
public record InstructedBalance11
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_wj-jEeaqEemtTOaHuc_63w")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_wj-jE-aqEemtTOaHuc_63w")]
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_wj-jFeaqEemtTOaHuc_63w")]
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_wj-jF-aqEemtTOaHuc_63w")]
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_wj-jGeaqEemtTOaHuc_63w")]
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; init; }

    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_wj-jG-aqEemtTOaHuc_63w")]
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_wj-jHeaqEemtTOaHuc_63w")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public InstructedCorporateActionOption12? OptionDetails { get; init; }
}
