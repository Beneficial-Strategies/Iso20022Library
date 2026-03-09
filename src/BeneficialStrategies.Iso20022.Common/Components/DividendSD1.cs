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
/// Extension to specify rates of a corporate action.
/// </summary>
[IsoId("_LsY4IzLZEeGkgP4mOiMAHQ")]
[DisplayName("Dividend SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DividendSD1
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
    [IsoId("_xoExQFO_EeGs_NnqHXQZkw")]
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
    /// Provides the total annual dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_bSUrMDLZEeGkgP4mOiMAHQ")]
    [DisplayName("Total Annual Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAnlDvddRate")]
    #endif
    [IsoXmlTag("TtlAnlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat16Choice_? TotalAnnualDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat16Choice_? TotalAnnualDividendRate { get; init; } 
    #else
    public RateAndAmountFormat16Choice_? TotalAnnualDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the maximum annual total dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_pHPk4DLfEeGkgP4mOiMAHQ")]
    [DisplayName("Maximum Annual Total Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAnlTtlDvddRate")]
    #endif
    [IsoXmlTag("MaxAnlTtlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat16Choice_? MaximumAnnualTotalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat16Choice_? MaximumAnnualTotalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat16Choice_? MaximumAnnualTotalDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the minimum annual total dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_sTihwDLfEeGkgP4mOiMAHQ")]
    [DisplayName("Minimum Annual Total Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinAnlTtlDvddRate")]
    #endif
    [IsoXmlTag("MinAnlTtlDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat16Choice_? MinimumAnnualTotalDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat16Choice_? MinimumAnnualTotalDividendRate { get; init; } 
    #else
    public RateAndAmountFormat16Choice_? MinimumAnnualTotalDividendRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
