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
/// Instruction for a change to an account status and reason for the change.
/// </summary>
[IsoId("_et6_QHi5EeaRm5xIK6nGuQ")]
[DisplayName("Account Status Update Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountStatusUpdateInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountStatusUpdateInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountStatusUpdateInstruction1( AccountStatusUpdateInstruction1Choice_ reqUpdateInstruction )
    {
        UpdateInstruction = reqUpdateInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of status change instructed for the account status.
    /// </summary>
    [IsoId("_mJ2lUHi5EeaRm5xIK6nGuQ")]
    [DisplayName("Update Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdInstr")]
    #endif
    [IsoXmlTag("UpdInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    #else
    public AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    [IsoId("_Z0gj0Hi6EeaRm5xIK6nGuQ")]
    [DisplayName("Update Instruction Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdInstrRsn")]
    #endif
    [IsoXmlTag("UpdInstrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; init; } 
    #else
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
