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
/// Extension to choose between an amount or an unspecified rate.
/// </summary>
[IsoId("_1eZc4zLhEeGkgP4mOiMAHQ")]
[DisplayName("Gross Dividend Rate Format 6 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GrossDividendRateFormat6SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_4t4csFPHEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the maximum dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_GNiV1TYmEeGFarbLo5oXPg")]
    [DisplayName("Maximum Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxDvddRate")]
    #endif
    [IsoXmlTag("MaxDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat16Choice_? MaximumDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat16Choice_? MaximumDividendRate { get; init; } 
    #else
    public RateAndAmountFormat16Choice_? MaximumDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the minimum dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_cumH9zYmEeGFarbLo5oXPg")]
    [DisplayName("Minimum Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDvddRate")]
    #endif
    [IsoXmlTag("MinDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat16Choice_? MinimumDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat16Choice_? MinimumDividendRate { get; init; } 
    #else
    public RateAndAmountFormat16Choice_? MinimumDividendRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
