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
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_6nwg0UKSEeWuG5hmkcJWSQ")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation22( System.String reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_7DbwMUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the organisation in short form.
    /// </summary>
    [IsoId("_yyVfkVxjEeWvPv3PXpS3fw")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    [IsoId("_7DbwM0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification72Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification72Choice_? Identification { get; init; } 
    #else
    public PartyIdentification72Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_7DbwNUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Legal Entity Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglNttyIdr")]
    #endif
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalEntityIdentifier { get; init; } 
    #else
    public System.String? LegalEntityIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_7DbwN0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_7DbwOUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Registration Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnCtry")]
    #endif
    [IsoXmlTag("RegnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RegistrationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RegistrationCountry { get; init; } 
    #else
    public string? RegistrationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_7DbwO0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Registration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDt")]
    #endif
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RegistrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RegistrationDate { get; init; } 
    #else
    public System.DateOnly? RegistrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__dOlgUKTEeWuG5hmkcJWSQ")]
    [DisplayName("Modified Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdPstlAdr")]
    #endif
    [IsoXmlTag("ModfdPstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope34? ModifiedPostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope34? ModifiedPostalAddress { get; init; } 
    #else
    public ModificationScope34? ModifiedPostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Type of organisation.
    /// </summary>
    [IsoId("_7DbwRUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Type Of Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfOrg")]
    #endif
    [IsoXmlTag("TpOfOrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
    #else
    public OrganisationType1Choice_? TypeOfOrganisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
