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
[IsoId("_aF_Eo1VCEembSPFgeLJ9eg")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification219
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification219 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification219( PersonName2 reqNameAndAddress,PartyIdentification195Choice_ reqIdentification )
    {
        NameAndAddress = reqNameAndAddress;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_aF_EpVVCEembSPFgeLJ9eg")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonName2 NameAndAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonName2 NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonName2 NameAndAddress { get; init; } 
    #else
    public PersonName2 NameAndAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_aF_EpFVCEembSPFgeLJ9eg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification195Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification195Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification195Choice_ Identification { get; init; } 
    #else
    public PartyIdentification195Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the contact person by its name, given name and address.
    /// </summary>
    [IsoId("_SlZLkVVDEembSPFgeLJ9eg")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification2? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification2? ContactPerson { get; init; } 
    #else
    public ContactIdentification2? ContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}
