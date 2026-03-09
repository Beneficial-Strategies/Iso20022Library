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
/// Provides details about a system and about a member of a system.
/// </summary>
[IsoId("_78fiFaMgEeCJ6YNENx4h-w_-1952044012")]
[DisplayName("System Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemMember2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemMember2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemMember2( MemberIdentification2Choice_ reqMemberIdentification )
    {
        MemberIdentification = reqMemberIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_78fiFqMgEeCJ6YNENx4h-w_-944964888")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #else
    public SystemIdentification2Choice_? SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_78fiF6MgEeCJ6YNENx4h-w_963171998")]
    [DisplayName("Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbId")]
    #endif
    [IsoXmlTag("MmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemberIdentification2Choice_ MemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemberIdentification2Choice_ MemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification2Choice_ MemberIdentification { get; init; } 
    #else
    public MemberIdentification2Choice_ MemberIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
