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
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_mBzOifJqEeiJn9rM2Znz2w")]
[DisplayName("Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of adjustment.
    /// </summary>
    [IsoId("_mBzOjvJqEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of adjustment.
    /// </summary>
    [IsoId("_mBzOi_JqEeiJn9rM2Znz2w")]
    [DisplayName("Additional Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTp")]
    #endif
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalType { get; init; } 
    #else
    public System.String? AdditionalType { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the adjustment.
    /// </summary>
    [IsoId("_mBzOivJqEeiJn9rM2Znz2w")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_mBzOj_JqEeiJn9rM2Znz2w")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Promotion or adjustment code.
    /// </summary>
    [IsoId("_sn8w4Rs4EeqrvK3udMUsNQ")]
    [DisplayName("Promotion Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmtnCd")]
    #endif
    [IsoXmlTag("PrmtnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PromotionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PromotionCode { get; init; } 
    #else
    public System.String? PromotionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the percentage value of the discount (when applicable).
    /// </summary>
    [IsoId("_mBzOkPJqEeiJn9rM2Znz2w")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Percentage { get; init; } 
    #else
    public System.Decimal? Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Contains amount of the adjustment, exclusive of tax.
    /// </summary>
    [IsoId("_mBzOjfJqEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntAmt")]
    #endif
    [IsoXmlTag("AdjstmntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not tax was calculated on the original amount of the transaction. 
    /// Note that false (or not present) indicates applicable taxes are based on adjusted amount.
    /// </summary>
    [IsoId("_mBzOkfJqEeiJn9rM2Znz2w")]
    [DisplayName("Tax Calculated On Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctdOnOrgnlAmt")]
    #endif
    [IsoXmlTag("TaxClctdOnOrgnlAmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TaxCalculatedOnOriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxCalculatedOnOriginalAmount { get; init; } 
    #else
    public System.String? TaxCalculatedOnOriginalAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
