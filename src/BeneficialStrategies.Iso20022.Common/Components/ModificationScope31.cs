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
[IsoId("_BugF4SFpEeW9XJWqfgXIIA")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope31( DataModification1Code reqModificationScopeIndication,DocumentToSend3 reqServiceLevelAgreement )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        ServiceLevelAgreement = reqServiceLevelAgreement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_CJ3zQSFpEeW9XJWqfgXIIA")]
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
    /// Identification of information which is part of a service level agreement.
    /// </summary>
    [IsoId("_CJ3zQyFpEeW9XJWqfgXIIA")]
    [DisplayName("Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmt")]
    #endif
    [IsoXmlTag("SvcLvlAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentToSend3 ServiceLevelAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentToSend3 ServiceLevelAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentToSend3 ServiceLevelAgreement { get; init; } 
    #else
    public DocumentToSend3 ServiceLevelAgreement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
