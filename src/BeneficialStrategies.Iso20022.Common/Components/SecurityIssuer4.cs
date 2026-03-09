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
[IsoId("_F_G3Z8guEeuGrNSsxk3B0A")]
[DisplayName("Security Issuer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIssuer4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIssuer4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIssuer4( string reqJurisdictionCountry )
    {
        JurisdictionCountry = reqJurisdictionCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal entity identification of the issuer of the security.
    /// </summary>
    [IsoId("_GAfXccguEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? Identification { get; init; } 
    #else
    public OrganisationIdentification15Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. In case of securities issued by a foreign subsidiary, the jurisdiction of the ultimate parent company shall be reported or, if not known, jurisdiction of the subsidiary.
    /// </summary>
    [IsoId("_GAfXc8guEeuGrNSsxk3B0A")]
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
