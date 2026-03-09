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
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("_SfCMQtp-Ed-ak6NoX_4Aeg_664619223")]
[DisplayName("Statistics By Predefined Time Periods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsByPredefinedTimePeriods2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_SfCMQ9p-Ed-ak6NoX_4Aeg_664619259")]
    [DisplayName("Highest Price Value 12 Months")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstPricVal12Mnths")]
    #endif
    [IsoXmlTag("HghstPricVal12Mnths")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue5? HighestPriceValue12Months { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue5? HighestPriceValue12Months { get; init; } 
    #else
    public PriceValue5? HighestPriceValue12Months { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_SfCMRNp-Ed-ak6NoX_4Aeg_665539367")]
    [DisplayName("Lowest Price Value 12 Months")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstPricVal12Mnths")]
    #endif
    [IsoXmlTag("LwstPricVal12Mnths")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue5? LowestPriceValue12Months { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue5? LowestPriceValue12Months { get; init; } 
    #else
    public PriceValue5? LowestPriceValue12Months { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a one year period.
    /// </summary>
    [IsoId("_SfCMRdp-Ed-ak6NoX_4Aeg_665539618")]
    [DisplayName("One Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYrPricChng")]
    #endif
    [IsoXmlTag("OneYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueChange1? OneYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueChange1? OneYearPriceChange { get; init; } 
    #else
    public PriceValueChange1? OneYearPriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a three year period.
    /// </summary>
    [IsoId("_SfCMRtp-Ed-ak6NoX_4Aeg_665539990")]
    [DisplayName("Three Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrPricChng")]
    #endif
    [IsoXmlTag("ThreeYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueChange1? ThreeYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueChange1? ThreeYearPriceChange { get; init; } 
    #else
    public PriceValueChange1? ThreeYearPriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a five year period.
    /// </summary>
    [IsoId("_SfCMR9p-Ed-ak6NoX_4Aeg_665540323")]
    [DisplayName("Five Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FiveYrPricChng")]
    #endif
    [IsoXmlTag("FiveYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueChange1? FiveYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueChange1? FiveYearPriceChange { get; init; } 
    #else
    public PriceValueChange1? FiveYearPriceChange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
