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
/// Information about the members of a system.
/// </summary>
[IsoId("_kEyRFXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Member5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Word by which something is called or known or the family name of a person.
    /// </summary>
    [IsoId("_kPQbsXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
    /// </summary>
    [IsoId("_kPQbs3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Return Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrAdr")]
    #endif
    [IsoXmlTag("RtrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberIdentification3Choice_? ReturnAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification3Choice_? ReturnAddress { get; init; } 
    #else
    public MemberIdentification3Choice_? ReturnAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_kPQbtXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? Account { get; init; } 
    #else
    public CashAccount38? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    [IsoId("_kPQbt3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemMemberType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMemberType1Choice_? Type { get; init; } 
    #else
    public SystemMemberType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a member in a system, for example enabled or deleted.
    /// </summary>
    [IsoId("_kPQbuXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemMemberStatus1Choice_? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMemberStatus1Choice_? Status { get; init; } 
    #else
    public SystemMemberStatus1Choice_? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    [IsoId("_kPQbu3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Contact Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctRef")]
    #endif
    [IsoXmlTag("CtctRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentificationAndAddress2? ContactReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentificationAndAddress2? ContactReference { get; init; } 
    #else
    public ContactIdentificationAndAddress2? ContactReference { get; set; } 
    #endif
    
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_kPQbvXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComAdr")]
    #endif
    [IsoXmlTag("ComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress10? CommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress10? CommunicationAddress { get; init; } 
    #else
    public CommunicationAddress10? CommunicationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
