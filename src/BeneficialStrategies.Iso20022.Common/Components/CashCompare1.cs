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
/// Data specific to cash and related fields used as a collateral.
/// </summary>
[IsoId("_kl1m0dMGEem1A4OOmCK97A")]
[DisplayName("Cash Compare")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashCompare1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashCompare1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashCompare1( CompareAmountAndDirection1 reqValue,ComparePercentageRate2 reqHaircutOrMargin )
    {
        Value = reqValue;
        HaircutOrMargin = reqHaircutOrMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_qdgk0NMGEem1A4OOmCK97A")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CompareAmountAndDirection1 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CompareAmountAndDirection1 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection1 Value { get; init; } 
    #else
    public CompareAmountAndDirection1 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_3kK5ENMGEem1A4OOmCK97A")]
    [DisplayName("Haircut Or Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrcutOrMrgn")]
    #endif
    [IsoXmlTag("HrcutOrMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ComparePercentageRate2 HaircutOrMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ComparePercentageRate2 HaircutOrMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2 HaircutOrMargin { get; init; } 
    #else
    public ComparePercentageRate2 HaircutOrMargin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
