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
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_S0j3MQEcEeCQm6a_G2yO_w_1452898168")]
[DisplayName("Line Item Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemTax1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_S0toIAEcEeCQm6a_G2yO_w_525289040")]
    [DisplayName("Calculated Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdAmt")]
    #endif
    [IsoXmlTag("ClctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #else
    public CurrencyAndAmount? CalculatedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_S0toIQEcEeCQm6a_G2yO_w_698047193")]
    [DisplayName("Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpCd")]
    #endif
    [IsoXmlTag("TpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxTypeFormat1Choice_? TypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxTypeFormat1Choice_? TypeCode { get; init; } 
    #else
    public TaxTypeFormat1Choice_? TypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the tax point date when this tax, levy or duty becomes applicable.
    /// </summary>
    [IsoId("_S0toIgEcEeCQm6a_G2yO_w_1128406293")]
    [DisplayName("Tax Point Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPtDt")]
    #endif
    [IsoXmlTag("TaxPtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TaxPointDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TaxPointDate { get; init; } 
    #else
    public System.DateOnly? TaxPointDate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0toIwEcEeCQm6a_G2yO_w_-316336554")]
    [DisplayName("Calculated Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdRate")]
    #endif
    [IsoXmlTag("ClctdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CalculatedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CalculatedRate { get; init; } 
    #else
    public System.Decimal? CalculatedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Code specifying the category to which this tax, levy or duty applies, such as codes for &apos;exempt from tax&apos;, &apos;standard rate&apos;, &quot;free export item - tax not charged&apos;.
    /// </summary>
    [IsoId("_S0toJAEcEeCQm6a_G2yO_w_-344611001")]
    [DisplayName("Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyCd")]
    #endif
    [IsoXmlTag("CtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? CategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CategoryCode { get; init; } 
    #else
    public System.String? CategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Category name, expressed as text, of the tax, levy or duty.
    /// </summary>
    [IsoId("_S0toJQEcEeCQm6a_G2yO_w_-1190517937")]
    [DisplayName("Category Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyNm")]
    #endif
    [IsoXmlTag("CtgyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CategoryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CategoryName { get; init; } 
    #else
    public System.String? CategoryName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
