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
[IsoId("_Q9aTcz6BEemPvNTzinB5Vw")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification218
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification218 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification218( PartyRole6Choice_ reqRole,PartyIdentification205Choice_ reqIdentification )
    {
        Role = reqRole;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Role played by the third party.
    /// </summary>
    [IsoId("_5561AI6VEemzmeK8_tPygg")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyRole6Choice_ Role { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyRole6Choice_ Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyRole6Choice_ Role { get; init; } 
    #else
    public PartyRole6Choice_ Role { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the third party.
    /// </summary>
    [IsoId("_qSleUI6WEemzmeK8_tPygg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification205Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification205Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification205Choice_ Identification { get; init; } 
    #else
    public PartyIdentification205Choice_ Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
