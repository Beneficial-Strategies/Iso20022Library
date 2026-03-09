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
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_SlbvM9p-Ed-ak6NoX_4Aeg_-655710552")]
[DisplayName("Total Taxes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalTaxes3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the taxes for a specific order.
    /// </summary>
    [IsoId("_SlbvNNp-Ed-ak6NoX_4Aeg_-655709854")]
    [DisplayName("Total Amount Of Taxes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtOfTaxs")]
    #endif
    [IsoXmlTag("TtlAmtOfTaxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_SlbvNdp-Ed-ak6NoX_4Aeg_-1861992641")]
    [DisplayName("Taxable Income Per Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerDvdd")]
    #endif
    [IsoXmlTag("TaxblIncmPerDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvNtp-Ed-ak6NoX_4Aeg_1440938177")]
    [DisplayName("EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUCptlGn")]
    #endif
    [IsoXmlTag("EUCptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #else
    public EUCapitalGain2Code? EUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvN9p-Ed-ak6NoX_4Aeg_1440938995")]
    [DisplayName("Extended EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedEUCptlGn")]
    #endif
    [IsoXmlTag("XtndedEUCptlGn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedEUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedEUCapitalGain { get; init; } 
    #else
    public System.String? ExtendedEUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvONp-Ed-ak6NoX_4Aeg_-1861992088")]
    [DisplayName("EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUDvddSts")]
    #endif
    [IsoXmlTag("EUDvddSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #else
    public EUDividendStatus1Code? EUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvOdp-Ed-ak6NoX_4Aeg_-1861991218")]
    [DisplayName("Extended EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedEUDvddSts")]
    #endif
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedEUDividendStatus { get; init; } 
    #else
    public System.String? ExtendedEUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_SllgMNp-Ed-ak6NoX_4Aeg_1230792355")]
    [DisplayName("Percentage Of Debt Claim")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfDebtClm")]
    #endif
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfDebtClaim { get; init; } 
    #else
    public System.Decimal? PercentageOfDebtClaim { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_SllgMdp-Ed-ak6NoX_4Aeg_-655709586")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax14? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax14? TaxDetails { get; init; } 
    #else
    public Tax14? TaxDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
