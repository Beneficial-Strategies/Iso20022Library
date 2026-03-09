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
/// Describes the details of an organisation.
/// </summary>
[IsoId("_BVSV3W49EeiU9cctagi5ow")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification138
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification138 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification138( System.String reqName,Party43Choice_ reqIdentification )
    {
        Name = reqName;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_BgdrEW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_BgdrE249EeiU9cctagi5ow")]
    [DisplayName("Legal Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglNm")]
    #endif
    [IsoXmlTag("LglNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? LegalName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalName { get; init; } 
    #else
    public System.String? LegalName { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_BgdrFW49EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? PostalAddress { get; init; } 
    #else
    public PostalAddress24? PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way to identify the party.
    /// </summary>
    [IsoId("_BgdrF249EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party43Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party43Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party43Choice_ Identification { get; init; } 
    #else
    public Party43Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_BgdrGW49EeiU9cctagi5ow")]
    [DisplayName("Country Of Residence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfRes")]
    #endif
    [IsoXmlTag("CtryOfRes")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfResidence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfResidence { get; init; } 
    #else
    public string? CountryOfResidence { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how to contact the party.
    /// </summary>
    [IsoId("_BgdrG249EeiU9cctagi5ow")]
    [DisplayName("Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctDtls")]
    #endif
    [IsoXmlTag("CtctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact4? ContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact4? ContactDetails { get; init; } 
    #else
    public Contact4? ContactDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
