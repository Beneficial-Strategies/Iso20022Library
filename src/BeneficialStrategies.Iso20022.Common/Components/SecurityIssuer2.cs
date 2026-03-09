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
/// Specifies the identification of the issuer of a security.
/// </summary>
[IsoId("_cD9apbQ0EemI67HK7aviyg")]
[DisplayName("Security Issuer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIssuer2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIssuer2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIssuer2( string reqJurisdictionCountry )
    {
        JurisdictionCountry = reqJurisdictionCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal entity identification of the issuer of the security.
    /// </summary>
    [IsoId("_cIk00bQ0EemI67HK7aviyg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? Identification { get; init; } 
    #else
    public OrganisationIdentification9Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. In case of securities issued by a foreign subsidiary, the jurisdiction of the ultimate parent company shall be reported or, if not known, jurisdiction of the subsidiary.
    /// </summary>
    [IsoId("_cIk007Q0EemI67HK7aviyg")]
    [DisplayName("Jurisdiction Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JursdctnCtry")]
    #endif
    [IsoXmlTag("JursdctnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode JurisdictionCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string JurisdictionCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string JurisdictionCountry { get; init; } 
    #else
    public string JurisdictionCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
