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
/// Provides information about the agent.
/// </summary>
[IsoId("_Pc3bwNp-Ed-ak6NoX_4Aeg_-1605492911")]
[DisplayName("Corporate Action Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAgent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionAgent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionAgent1( PartyIdentification2Choice_ reqAgentIdentification,AgentRole1FormatChoice_ reqAgentRole )
    {
        AgentIdentification = reqAgentIdentification;
        AgentRole = reqAgentRole;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the agent.
    /// </summary>
    [IsoId("_Pc3bwdp-Ed-ak6NoX_4Aeg_637142441")]
    [DisplayName("Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtId")]
    #endif
    [IsoXmlTag("AgtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ AgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Role played by the agent.
    /// </summary>
    [IsoId("_Pc3bwtp-Ed-ak6NoX_4Aeg_762741819")]
    [DisplayName("Agent Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtRole")]
    #endif
    [IsoXmlTag("AgtRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgentRole1FormatChoice_ AgentRole { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgentRole1FormatChoice_ AgentRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgentRole1FormatChoice_ AgentRole { get; init; } 
    #else
    public AgentRole1FormatChoice_ AgentRole { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person at the agent.
    /// </summary>
    [IsoId("_Pc3bw9p-Ed-ak6NoX_4Aeg_518579733")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress5? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress5? ContactPerson { get; init; } 
    #else
    public NameAndAddress5? ContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}
