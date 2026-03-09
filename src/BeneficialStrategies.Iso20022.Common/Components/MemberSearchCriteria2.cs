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
/// Defines the criteria used to search for a member.
/// </summary>
[IsoId("_8G7QcaMgEeCJ6YNENx4h-w_1746030860")]
[DisplayName("Member Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MemberSearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_8G7QcqMgEeCJ6YNENx4h-w_-1946163269")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberIdentification2Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification2Choice_? Identification { get; init; } 
    #else
    public MemberIdentification2Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    [IsoId("_8G7Qc6MgEeCJ6YNENx4h-w_663964676")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberType1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberType1Code? Type { get; init; } 
    #else
    public MemberType1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a member in a system, such as enabled or deleted.
    /// </summary>
    [IsoId("_8G7QdKMgEeCJ6YNENx4h-w_-493200358")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberStatus1Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberStatus1Code? Status { get; init; } 
    #else
    public MemberStatus1Code? Status { get; set; } 
    #endif
    
    
    #nullable disable
    
}
