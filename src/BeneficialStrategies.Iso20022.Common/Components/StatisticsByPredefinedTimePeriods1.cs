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
[IsoId("_VZS989p-Ed-ak6NoX_4Aeg_-616872931")]
[DisplayName("Statistics By Predefined Time Periods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsByPredefinedTimePeriods1
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
    [IsoId("_VZS99Np-Ed-ak6NoX_4Aeg_-80104993")]
    [DisplayName("Highest Price Value 12 Months")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstPricVal12Mnths")]
    #endif
    [IsoXmlTag("HghstPricVal12Mnths")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? HighestPriceValue12Months { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? HighestPriceValue12Months { get; init; } 
    #else
    public PriceValue1? HighestPriceValue12Months { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_VZS99dp-Ed-ak6NoX_4Aeg_1198045150")]
    [DisplayName("Lowest Price Value 12 Months")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstPricVal12Mnths")]
    #endif
    [IsoXmlTag("LwstPricVal12Mnths")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? LowestPriceValue12Months { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? LowestPriceValue12Months { get; init; } 
    #else
    public PriceValue1? LowestPriceValue12Months { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a one year period.
    /// </summary>
    [IsoId("_VZS99tp-Ed-ak6NoX_4Aeg_1251612280")]
    [DisplayName("One Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYrPricChng")]
    #endif
    [IsoXmlTag("OneYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue2? OneYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue2? OneYearPriceChange { get; init; } 
    #else
    public PriceValue2? OneYearPriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a three year period.
    /// </summary>
    [IsoId("_VZS999p-Ed-ak6NoX_4Aeg_1282086108")]
    [DisplayName("Three Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrPricChng")]
    #endif
    [IsoXmlTag("ThreeYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue2? ThreeYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue2? ThreeYearPriceChange { get; init; } 
    #else
    public PriceValue2? ThreeYearPriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price over a five year period.
    /// </summary>
    [IsoId("_VZS9-Np-Ed-ak6NoX_4Aeg_1380901942")]
    [DisplayName("Five Year Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FiveYrPricChng")]
    #endif
    [IsoXmlTag("FiveYrPricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue2? FiveYearPriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue2? FiveYearPriceChange { get; init; } 
    #else
    public PriceValue2? FiveYearPriceChange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
