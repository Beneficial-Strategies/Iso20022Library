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
[IsoId("_wSkDc-aqEemtTOaHuc_63w")]
[DisplayName("Instructed Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedBalance11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedBalance11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedBalance11( BalanceFormat5Choice_ reqTotalInstructedBalance )
    {
        TotalInstructedBalance = reqTotalInstructedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_wj-jEeaqEemtTOaHuc_63w")]
    [DisplayName("Total Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBal")]
    #endif
    [IsoXmlTag("TtlInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #else
    public BalanceFormat5Choice_ TotalInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_wj-jE-aqEemtTOaHuc_63w")]
    [DisplayName("Total Accepted Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAccptdInstrBal")]
    #endif
    [IsoXmlTag("TtlAccptdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_wj-jFeaqEemtTOaHuc_63w")]
    [DisplayName("Total Cancelled Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCancInstrBal")]
    #endif
    [IsoXmlTag("TtlCancInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_wj-jF-aqEemtTOaHuc_63w")]
    [DisplayName("Total Pending Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgInstrBal")]
    #endif
    [IsoXmlTag("TtlPdgInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_wj-jGeaqEemtTOaHuc_63w")]
    [DisplayName("Total Rejected Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRjctdInstrBal")]
    #endif
    [IsoXmlTag("TtlRjctdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_wj-jG-aqEemtTOaHuc_63w")]
    [DisplayName("Total Protect Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrtctInstrBal")]
    #endif
    [IsoXmlTag("TtlPrtctInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_wj-jHeaqEemtTOaHuc_63w")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructedCorporateActionOption12? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedCorporateActionOption12? OptionDetails { get; init; } 
    #else
    public InstructedCorporateActionOption12? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
