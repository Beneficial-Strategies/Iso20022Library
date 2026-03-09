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
[IsoId("_FD6i8ZlCEee-Zps0fZQaFQ")]
[DisplayName("Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Member3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, eg, returns or rejects.
    /// </summary>
    [IsoId("_FMsEcZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Return Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbRtrAdr")]
    #endif
    [IsoXmlTag("MmbRtrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemberIdentification2Choice_? MemberReturnAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification2Choice_? MemberReturnAddress { get; init; } 
    #else
    public MemberIdentification2Choice_? MemberReturnAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    [IsoId("_FMsEc5lCEee-Zps0fZQaFQ")]
    [DisplayName("Contact Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctRef")]
    #endif
    [IsoXmlTag("CtctRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentificationAndAddress1? ContactReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentificationAndAddress1? ContactReference { get; init; } 
    #else
    public ContactIdentificationAndAddress1? ContactReference { get; set; } 
    #endif
    
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_FMsEdZlCEee-Zps0fZQaFQ")]
    [DisplayName("Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComAdr")]
    #endif
    [IsoXmlTag("ComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress8? CommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress8? CommunicationAddress { get; init; } 
    #else
    public CommunicationAddress8? CommunicationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
