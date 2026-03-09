// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_D3WzDffQEeiNZp_PtLohLw")]
[DisplayName("Instructed Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedBalanceDetails10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedBalanceDetails10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedBalanceDetails10( BalanceFormat7Choice_ reqTotalInstructedBalance )
    {
        TotalInstructedBalance = reqTotalInstructedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_D3WzD_fQEeiNZp_PtLohLw")]
    [DisplayName("Total Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBal")]
    #endif
    [IsoXmlTag("TtlInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #else
    public BalanceFormat7Choice_ TotalInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_D3WzEffQEeiNZp_PtLohLw")]
    [DisplayName("Total Accepted Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAccptdInstrBal")]
    #endif
    [IsoXmlTag("TtlAccptdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_D3WzE_fQEeiNZp_PtLohLw")]
    [DisplayName("Total Cancelled Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCancInstrBal")]
    #endif
    [IsoXmlTag("TtlCancInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_D3WzFffQEeiNZp_PtLohLw")]
    [DisplayName("Total Pending Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgInstrBal")]
    #endif
    [IsoXmlTag("TtlPdgInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_D3WzF_fQEeiNZp_PtLohLw")]
    [DisplayName("Total Rejected Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRjctdInstrBal")]
    #endif
    [IsoXmlTag("TtlRjctdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_D3WzGffQEeiNZp_PtLohLw")]
    [DisplayName("Total Protect Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrtctInstrBal")]
    #endif
    [IsoXmlTag("TtlPrtctInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_D3WzG_fQEeiNZp_PtLohLw")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructedCorporateActionOption11? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedCorporateActionOption11? OptionDetails { get; init; } 
    #else
    public InstructedCorporateActionOption11? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
