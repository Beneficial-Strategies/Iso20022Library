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
/// Identification of a party.
/// </summary>
[IsoId("_OevfoU3hEeidB49bWZiS0g")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification132
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    [IsoId("_RyP3w03hEeidB49bWZiS0g")]
    [DisplayName("Any BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnyBIC")]
    #endif
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AnyBIC { get; init; } 
    #else
    public System.String? AnyBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [IsoId("_fA1Y8U3hEeidB49bWZiS0g")]
    [DisplayName("Clearing System Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSysMmbId")]
    #endif
    [IsoXmlTag("ClrSysMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; } 
    #else
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_RyP3xU3hEeidB49bWZiS0g")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress5? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress5? NameAndAddress { get; init; } 
    #else
    public NameAndAddress5? NameAndAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_RyP3xE3hEeidB49bWZiS0g")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryId")]
    #endif
    [IsoXmlTag("PrtryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification1? ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_OvOytU3hEeidB49bWZiS0g")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
