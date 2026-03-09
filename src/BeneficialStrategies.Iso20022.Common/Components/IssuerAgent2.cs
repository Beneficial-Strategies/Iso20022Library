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
/// Specifies the role of the issuer agent.
/// </summary>
[IsoId("_ciBrAVthEeSwKe7KuKvXhg")]
[DisplayName("Issuer Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IssuerAgent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IssuerAgent2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IssuerAgent2( PartyIdentification40Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies issuer agent.
    /// </summary>
    [IsoId("_c_C-M1thEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification40Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification40Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40Choice_ Identification { get; init; } 
    #else
    public PartyIdentification40Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the issuer agent.
    /// </summary>
    [IsoId("_c_C-NVthEeSwKe7KuKvXhg")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgentRole1Code? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgentRole1Code? Role { get; init; } 
    #else
    public AgentRole1Code? Role { get; set; } 
    #endif
    
    
    #nullable disable
    
}
