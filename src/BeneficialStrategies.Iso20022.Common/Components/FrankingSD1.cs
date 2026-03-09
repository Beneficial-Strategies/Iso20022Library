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
/// Franking details.
/// </summary>
[IsoId("_UFK5bW99EeKuY41pq1-dog")]
[DisplayName("Franking SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FrankingSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FrankingSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FrankingSD1( FrankingClass1Code reqFrankingClass )
    {
        FrankingClass = reqFrankingClass;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
    /// </summary>
    [IsoId("_UFK5em99EeKuY41pq1-dog")]
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
    /// Dividend / Distribution kind where the franking information apples to.
    /// </summary>
    [IsoId("_UFK5lW99EeKuY41pq1-dog")]
    [DisplayName("Franking Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrnkgClss")]
    #endif
    [IsoXmlTag("FrnkgClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FrankingClass1Code FrankingClass { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FrankingClass1Code FrankingClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FrankingClass1Code FrankingClass { get; init; } 
    #else
    public FrankingClass1Code FrankingClass { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator if the dividend is fully franked.
    /// </summary>
    [IsoId("_UFK5f299EeKuY41pq1-dog")]
    [DisplayName("Fully Franked Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdInd")]
    #endif
    [IsoXmlTag("FullyFrnkdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FullyFrankedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FullyFrankedIndicator { get; init; } 
    #else
    public System.String? FullyFrankedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of dividend that is franked.
    /// </summary>
    [IsoId("_UFK5i299EeKuY41pq1-dog")]
    [DisplayName("Franked Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrnkdPctg")]
    #endif
    [IsoXmlTag("FrnkdPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? FrankedPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FrankedPercentage { get; init; } 
    #else
    public System.Decimal? FrankedPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of dividend that is unfranked.
    /// </summary>
    [IsoId("_DSjMV7YsEeKtMMQEG6I5fw")]
    [DisplayName("Unfranked Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfrnkdPctg")]
    #endif
    [IsoXmlTag("UfrnkdPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? UnfrankedPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? UnfrankedPercentage { get; init; } 
    #else
    public System.Decimal? UnfrankedPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// The corporate tax rate for the for franking credit of the dividend.
    /// </summary>
    [IsoId("_UFK5kG99EeKuY41pq1-dog")]
    [DisplayName("Corporate Tax Rate For Franking Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpTaxRateForFrnkgCdt")]
    #endif
    [IsoXmlTag("CorpTaxRateForFrnkgCdt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CorporateTaxRateForFrankingCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CorporateTaxRateForFrankingCredit { get; init; } 
    #else
    public System.Decimal? CorporateTaxRateForFrankingCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Cents amount of the dividend which has been franked at 30%.
    /// </summary>
    [IsoId("_UFK5cG99EeKuY41pq1-dog")]
    [DisplayName("Franked Amount Per Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrnkdAmtPerScty")]
    #endif
    [IsoXmlTag("FrnkdAmtPerScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? FrankedAmountPerSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? FrankedAmountPerSecurity { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? FrankedAmountPerSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the dividend which has been unfranked.|
    /// </summary>
    [IsoId("_UFK5dW99EeKuY41pq1-dog")]
    [DisplayName("Unfranked Amount Per Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfrnkdAmtPerScty")]
    #endif
    [IsoXmlTag("UfrnkdAmtPerScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? UnfrankedAmountPerSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? UnfrankedAmountPerSecurity { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? UnfrankedAmountPerSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Conduit foreign income (CFI) amount related to the corporate action.
    /// </summary>
    [IsoId("_UFK5hG99EeKuY41pq1-dog")]
    [DisplayName("Conduit Foreign Income Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CndtFrgnIncmAmt")]
    #endif
    [IsoXmlTag("CndtFrgnIncmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? ConduitForeignIncomeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? ConduitForeignIncomeAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? ConduitForeignIncomeAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
