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
/// Maintenance command which has requested the device report.
/// </summary>
[IsoId("_bfXL4V_UEeeD0NpJQPACzA")]
[DisplayName("ATM Command")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommand12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCommand12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCommand12( ATMCommand6Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_bnvr0V_UEeeD0NpJQPACzA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCommand6Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCommand6Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand6Code Type { get; init; } 
    #else
    public ATMCommand6Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_bnvr01_UEeeD0NpJQPACzA")]
    [DisplayName("Command Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdId")]
    #endif
    [IsoXmlTag("CmdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #else
    public ATMCommandIdentification1? CommandIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
