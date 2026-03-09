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
/// Maintenance command to perform on an ATM.
/// </summary>
[IsoId("_W_3jIa2BEeWMg5rOByfExw")]
[DisplayName("ATM Command")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommand7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCommand7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCommand7( ATMCommand4Code reqType,TMSContactLevel2Code reqUrgency )
    {
        Type = reqType;
        Urgency = reqUrgency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_XMiGIa2BEeWMg5rOByfExw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCommand4Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCommand4Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand4Code Type { get; init; } 
    #else
    public ATMCommand4Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_XMiGI62BEeWMg5rOByfExw")]
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
    [IsoId("_XMiGJa2BEeWMg5rOByfExw")]
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
    [IsoId("_XMiGJ62BEeWMg5rOByfExw")]
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
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_XMiGKa2BEeWMg5rOByfExw")]
    [DisplayName("Command Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdParams")]
    #endif
    [IsoXmlTag("CmdParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandParameters1Choice_? CommandParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandParameters1Choice_? CommandParameters { get; init; } 
    #else
    public ATMCommandParameters1Choice_? CommandParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
