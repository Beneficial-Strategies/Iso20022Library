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
/// Information about the kind of modification request for party reference data.
/// </summary>
[IsoId("_xtxKwYv-Eei289CGNqs21g")]
[DisplayName("System Party Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemPartyModification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemPartyModification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemPartyModification2( DataModification1Code reqScopeIndication,SystemPartyModification2Choice_ reqRequestedModification )
    {
        ScopeIndication = reqScopeIndication;
        RequestedModification = reqRequestedModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_x86aAYv-Eei289CGNqs21g")]
    [DisplayName("Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScpIndctn")]
    #endif
    [IsoXmlTag("ScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ScopeIndication { get; init; } 
    #else
    public DataModification1Code ScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the set of elements to be modified for the party reference data.
    /// </summary>
    [IsoId("_x87BEYv-Eei289CGNqs21g")]
    [DisplayName("Requested Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdMod")]
    #endif
    [IsoXmlTag("ReqdMod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyModification2Choice_ RequestedModification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyModification2Choice_ RequestedModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyModification2Choice_ RequestedModification { get; init; } 
    #else
    public SystemPartyModification2Choice_ RequestedModification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
