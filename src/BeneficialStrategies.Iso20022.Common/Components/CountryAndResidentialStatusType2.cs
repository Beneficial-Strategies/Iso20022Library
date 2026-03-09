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
/// Country and residential status.
/// </summary>
[IsoId("_0D9OcSDZEeWCLu74WLgP4w")]
[DisplayName("Country And Residential Status Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CountryAndResidentialStatusType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CountryAndResidentialStatusType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CountryAndResidentialStatusType2( string reqCountry,ResidentialStatus1Code reqResidentialStatus )
    {
        Country = reqCountry;
        ResidentialStatus = reqResidentialStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country to which the residential status is applicable.
    /// </summary>
    [IsoId("_0gOTsSDZEeWCLu74WLgP4w")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Residential status of the organisation or individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_0gOTsyDZEeWCLu74WLgP4w")]
    [DisplayName("Residential Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ResdtlSts")]
    #endif
    [IsoXmlTag("ResdtlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResidentialStatus1Code ResidentialStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResidentialStatus1Code ResidentialStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidentialStatus1Code ResidentialStatus { get; init; } 
    #else
    public ResidentialStatus1Code ResidentialStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
