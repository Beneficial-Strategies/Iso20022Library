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
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_-IRJIXhhEeidzqjNEfehPg")]
[DisplayName("Contact Identification And Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContactIdentificationAndAddress2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContactIdentificationAndAddress2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContactIdentificationAndAddress2( PaymentRole1Choice_ reqRole,CommunicationAddress10 reqCommunicationAddress )
    {
        Role = reqRole;
        CommunicationAddress = reqCommunicationAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_-U5P4XhhEeidzqjNEfehPg")]
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
    /// Role of the party in the payment.
    /// </summary>
    [IsoId("_-U5P43hhEeidzqjNEfehPg")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentRole1Choice_ Role { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentRole1Choice_ Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentRole1Choice_ Role { get; init; } 
    #else
    public PaymentRole1Choice_ Role { get; set; } 
    #endif
    
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_-U5P5XhhEeidzqjNEfehPg")]
    [DisplayName("Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComAdr")]
    #endif
    [IsoXmlTag("ComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationAddress10 CommunicationAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationAddress10 CommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress10 CommunicationAddress { get; init; } 
    #else
    public CommunicationAddress10 CommunicationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
