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
[IsoId("_Ezqs8DtsEemIf7eyjCwinw")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification217
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification217 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification217( PersonName3 reqNameAndAddress,NaturalPersonIdentification1 reqIdentification )
    {
        NameAndAddress = reqNameAndAddress;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_ZI12UztsEemIf7eyjCwinw")]
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
    [IsoId("_ZI12VDtsEemIf7eyjCwinw")]
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
    /// Natural person identification details.
    /// </summary>
    [IsoId("_ZI12VTtsEemIf7eyjCwinw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NaturalPersonIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NaturalPersonIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NaturalPersonIdentification1 Identification { get; init; } 
    #else
    public NaturalPersonIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("_Bx0hAX1hEemTjI54yVVOfw")]
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
    /// Date on which and place at which a person is born.
    /// </summary>
    [IsoId("_hnbAoX1hEemTjI54yVVOfw")]
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
    
    /// <summary>
    /// Type of investor.
    /// </summary>
    [IsoId("_Y7oMQIk1EemZteIrPMIV3g")]
    [DisplayName("Investor Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTp")]
    #endif
    [IsoXmlTag("InvstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType1Choice_? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType1Choice_? InvestorType { get; init; } 
    #else
    public InvestorType1Choice_? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the ownership on an asset.
    /// </summary>
    [IsoId("_xi5zwYz1EemXJvzC2Wyt1g")]
    [DisplayName("Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ownrsh")]
    #endif
    [IsoXmlTag("Ownrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Ownership1? Ownership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Ownership1? Ownership { get; init; } 
    #else
    public Ownership1? Ownership { get; set; } 
    #endif
    
    
    #nullable disable
    
}
