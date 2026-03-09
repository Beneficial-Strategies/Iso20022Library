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
/// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
/// </summary>
[IsoId("_AmX48NokEeC60axPepSq7g_4921707")]
[DisplayName("Regulatory Stipulations")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryStipulations1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegulatoryStipulations1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryStipulations1( string reqCountry )
    {
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_Amhp8NokEeC60axPepSq7g_-2124829502")]
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
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or where they conduct business.
    /// </summary>
    [IsoId("_Amhp8dokEeC60axPepSq7g_1275857359")]
    [DisplayName("Stipulations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stiptns")]
    #endif
    [IsoXmlTag("Stiptns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    public SimpleValueList<System.String> Stipulations { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Amhp8dokEeC60axPepSq7g_1275857359
    
    
    #nullable disable
    
}
