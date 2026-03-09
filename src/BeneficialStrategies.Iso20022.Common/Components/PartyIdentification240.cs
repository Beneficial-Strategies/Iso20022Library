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
[IsoId("_7KtWtfQ0EeqAradXpAelDQ")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification240
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification240 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification240( PersonName3 reqNameAndAddress )
    {
        NameAndAddress = reqNameAndAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_7dmdgfQ0EeqAradXpAelDQ")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonName3 NameAndAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonName3 NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonName3 NameAndAddress { get; init; } 
    #else
    public PersonName3 NameAndAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_7dmdg_Q0EeqAradXpAelDQ")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [IsoId("_7dmdhfQ0EeqAradXpAelDQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NaturalPersonIdentification1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NaturalPersonIdentification1? Identification { get; init; } 
    #else
    public NaturalPersonIdentification1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("__9pr0vQ1EeqAradXpAelDQ")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Nationality { get; init; } 
    #else
    public string? Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    [IsoId("__9pr0_Q1EeqAradXpAelDQ")]
    [DisplayName("Date And Place Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndPlcOfBirth")]
    #endif
    [IsoXmlTag("DtAndPlcOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    #else
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
