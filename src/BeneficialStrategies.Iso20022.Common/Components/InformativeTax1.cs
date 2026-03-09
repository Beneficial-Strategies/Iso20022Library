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
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_fH5lkDh7EeaH-93K5JKmzw")]
[DisplayName("Informative Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformativeTax1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_mzHk0Th7EeaH-93K5JKmzw")]
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
    [IsoId("_s8YCEjh7EeaH-93K5JKmzw")]
    [DisplayName("EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUCptlGn")]
    #endif
    [IsoXmlTag("EUCptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain3Choice_? EUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain3Choice_? EUCapitalGain { get; init; } 
    #else
    public EUCapitalGain3Choice_? EUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_F6qEkjh8EeaH-93K5JKmzw")]
    [DisplayName("EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUDvddSts")]
    #endif
    [IsoXmlTag("EUDvddSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUDividendStatusType2Choice_? EUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUDividendStatusType2Choice_? EUDividendStatus { get; init; } 
    #else
    public EUDividendStatusType2Choice_? EUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_j7WRATh8EeaH-93K5JKmzw")]
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
    /// Information related to a specific tax that is provided for information purposes.
    /// </summary>
    [IsoId("_n8kqwTh8EeaH-93K5JKmzw")]
    [DisplayName("Individual Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvTax")]
    #endif
    [IsoXmlTag("IndvTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax32? IndividualTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax32? IndividualTax { get; init; } 
    #else
    public Tax32? IndividualTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
