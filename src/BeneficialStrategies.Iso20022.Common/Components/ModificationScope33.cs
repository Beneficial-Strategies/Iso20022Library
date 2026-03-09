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
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_pV0D4SJREeWOwvWbbXyDPw")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope33 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope33( DataModification1Code reqModificationScopeIndication,ReferredAgent2 reqPlacement )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        Placement = reqPlacement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_pyh1ESJREeWOwvWbbXyDPw")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification1Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_ypOI8CJREeWOwvWbbXyDPw")]
    [DisplayName("Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Plcmnt")]
    #endif
    [IsoXmlTag("Plcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReferredAgent2 Placement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReferredAgent2 Placement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredAgent2 Placement { get; init; } 
    #else
    public ReferredAgent2 Placement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
