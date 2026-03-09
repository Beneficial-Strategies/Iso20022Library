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
/// Market maker profile.
/// </summary>
[IsoId("_Mtd3oCDWEeWCLu74WLgP4w")]
[DisplayName("Market Maker Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketMakerProfile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period of the contract.
    /// </summary>
    [IsoId("_WSwW4CDWEeWCLu74WLgP4w")]
    [DisplayName("Contract Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctPrd")]
    #endif
    [IsoXmlTag("CtrctPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriodDetails1? ContractPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodDetails1? ContractPeriod { get; init; } 
    #else
    public DateTimePeriodDetails1? ContractPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the market maker is obligated to comply with the requirements of the contract it holds with the exchange or is exempt from these obligations.
    /// </summary>
    [IsoId("_YTJhUCDWEeWCLu74WLgP4w")]
    [DisplayName("Compliance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmplc")]
    #endif
    [IsoXmlTag("Cmplc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Compliance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Compliance { get; init; } 
    #else
    public System.String? Compliance { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the variation between the maximum accepted minimum and maximum value of an action.
    /// </summary>
    [IsoId("_bAeqQCDWEeWCLu74WLgP4w")]
    [DisplayName("Maximum Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSprd")]
    #endif
    [IsoXmlTag("MaxSprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MaximumSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MaximumSpread { get; init; } 
    #else
    public System.Decimal? MaximumSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of discount.
    /// </summary>
    [IsoId("_cvxdoCDWEeWCLu74WLgP4w")]
    [DisplayName("Discount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscnt")]
    #endif
    [IsoXmlTag("Dscnt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Discount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Discount { get; init; } 
    #else
    public System.Decimal? Discount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
