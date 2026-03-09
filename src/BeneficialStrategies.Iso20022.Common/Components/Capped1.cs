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
/// Information about a capped drawdown.
/// </summary>
[IsoId("_56qUIFNdEeijdq8ilaxyOA")]
[DisplayName("Capped")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Capped1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date of current reference period
    /// </summary>
    [IsoId("_EkpKkFNeEeijdq8ilaxyOA")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Income limit for the current period.
    /// </summary>
    [IsoId("_K4H60FNeEeijdq8ilaxyOA")]
    [DisplayName("Income Limit Current Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmLmtCurPrd")]
    #endif
    [IsoXmlTag("IncmLmtCurPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitCurrentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitCurrentPeriod { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitCurrentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Income taken in the current income year.
    /// </summary>
    [IsoId("_OwkzEFNeEeijdq8ilaxyOA")]
    [DisplayName("Income Current Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmCurPrd")]
    #endif
    [IsoXmlTag("IncmCurPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? IncomeCurrentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? IncomeCurrentPeriod { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? IncomeCurrentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Income limit for the next income year.
    /// </summary>
    [IsoId("_S8XeEFNeEeijdq8ilaxyOA")]
    [DisplayName("Income Limit Next Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmLmtNxtPrd")]
    #endif
    [IsoXmlTag("IncmLmtNxtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitNextPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitNextPeriod { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitNextPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the cap.
    /// </summary>
    [IsoId("_LqU3YZC1EeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
