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
/// Maintenance command the ATM must perform.
/// </summary>
[IsoId("_dy_AoYtFEeSxlKlAGYErFg")]
[DisplayName("ATM Command")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommand4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCommand4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCommand4( ATMCommand2Code reqType,TMSContactLevel2Code reqUrgency )
    {
        Type = reqType;
        Urgency = reqUrgency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_eFAkwYtFEeSxlKlAGYErFg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCommand2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCommand2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand2Code Type { get; init; } 
    #else
    public ATMCommand2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_eFAkw4tFEeSxlKlAGYErFg")]
    [DisplayName("Urgency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Urgcy")]
    #endif
    [IsoXmlTag("Urgcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSContactLevel2Code Urgency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSContactLevel2Code Urgency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSContactLevel2Code Urgency { get; init; } 
    #else
    public TMSContactLevel2Code Urgency { get; set; } 
    #endif
    
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_eFAkxYtFEeSxlKlAGYErFg")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DateTime { get; init; } 
    #else
    public System.DateTime? DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_eFAkx4tFEeSxlKlAGYErFg")]
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
    
    /// <summary>
    /// Reason for sending the command.
    /// </summary>
    [IsoId("_JejzQItHEeSxlKlAGYErFg")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandReason1Code? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandReason1Code? Reason { get; init; } 
    #else
    public ATMCommandReason1Code? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Trace of reasons by the entities in the path from the origin of the command to the ATM.
    /// </summary>
    [IsoId("_VhtcEItHEeSxlKlAGYErFg")]
    [DisplayName("Trace Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TracRsn")]
    #endif
    [IsoXmlTag("TracRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandReason1Code? TraceReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandReason1Code? TraceReason { get; init; } 
    #else
    public ATMCommandReason1Code? TraceReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the reason to request this command.
    /// </summary>
    [IsoId("_gOMz8ItHEeSxlKlAGYErFg")]
    [DisplayName("Additional Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsnInf")]
    #endif
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_eFAkyYtFEeSxlKlAGYErFg")]
    [DisplayName("Command Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdParams")]
    #endif
    [IsoXmlTag("CmdParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandParameters2Choice_? CommandParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandParameters2Choice_? CommandParameters { get; init; } 
    #else
    public ATMCommandParameters2Choice_? CommandParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
