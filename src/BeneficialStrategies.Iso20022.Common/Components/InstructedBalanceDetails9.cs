// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_sga5k7tGEeilsanBGAzy4A")]
[DisplayName("Instructed Balance Details")]
public partial record InstructedBalanceDetails9
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_sxh3MbtGEeilsanBGAzy4A")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_9BKHgLtGEeilsanBGAzy4A")]
    [DisplayName("Total Accepted Instruction Balance")]
    [IsoXmlTag("TtlAccptdInstrBal")]
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_IfgaILtHEeilsanBGAzy4A")]
    [DisplayName("Total Cancelled Instruction Balance")]
    [IsoXmlTag("TtlCancInstrBal")]
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_aa1-ULtHEeilsanBGAzy4A")]
    [DisplayName("Total Pending Instruction Balance")]
    [IsoXmlTag("TtlPdgInstrBal")]
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_n9lxoLtHEeilsanBGAzy4A")]
    [DisplayName("Total Rejected Instruction Balance")]
    [IsoXmlTag("TtlRjctdInstrBal")]
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_wmuxsLtHEeilsanBGAzy4A")]
    [DisplayName("Total Protect Instruction Balance")]
    [IsoXmlTag("TtlPrtctInstrBal")]
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; init; } 
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_sxh3M7tGEeilsanBGAzy4A")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public InstructedCorporateActionOption10? OptionDetails { get; init; } 
    
    
    #nullable disable
    
}
