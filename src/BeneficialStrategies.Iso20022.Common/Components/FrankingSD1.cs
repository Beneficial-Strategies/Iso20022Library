// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Franking details.
/// </summary>
[IsoId("_UFK5bW99EeKuY41pq1-dog")]
[DisplayName("Franking SD")]
public partial record FrankingSD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
    /// </summary>
    [IsoId("_UFK5em99EeKuY41pq1-dog")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Dividend / Distribution kind where the franking information apples to.
    /// </summary>
    [IsoId("_UFK5lW99EeKuY41pq1-dog")]
    [DisplayName("Franking Class")]
    [IsoXmlTag("FrnkgClss")]
    public required FrankingClass1Code FrankingClass { get; init; } 
    
    /// <summary>
    /// Indicator if the dividend is fully franked.
    /// </summary>
    [IsoId("_UFK5f299EeKuY41pq1-dog")]
    [DisplayName("Fully Franked Indicator")]
    [IsoXmlTag("FullyFrnkdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FullyFrankedIndicator { get; init; } 
    
    /// <summary>
    /// Percentage of dividend that is franked.
    /// </summary>
    [IsoId("_UFK5i299EeKuY41pq1-dog")]
    [DisplayName("Franked Percentage")]
    [IsoXmlTag("FrnkdPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? FrankedPercentage { get; init; } 
    
    /// <summary>
    /// Percentage of dividend that is unfranked.
    /// </summary>
    [IsoId("_DSjMV7YsEeKtMMQEG6I5fw")]
    [DisplayName("Unfranked Percentage")]
    [IsoXmlTag("UfrnkdPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? UnfrankedPercentage { get; init; } 
    
    /// <summary>
    /// The corporate tax rate for the for franking credit of the dividend.
    /// </summary>
    [IsoId("_UFK5kG99EeKuY41pq1-dog")]
    [DisplayName("Corporate Tax Rate For Franking Credit")]
    [IsoXmlTag("CorpTaxRateForFrnkgCdt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CorporateTaxRateForFrankingCredit { get; init; } 
    
    /// <summary>
    /// Cents amount of the dividend which has been franked at 30%.
    /// </summary>
    [IsoId("_UFK5cG99EeKuY41pq1-dog")]
    [DisplayName("Franked Amount Per Security")]
    [IsoXmlTag("FrnkdAmtPerScty")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? FrankedAmountPerSecurity { get; init; } 
    
    /// <summary>
    /// Amount of the dividend which has been unfranked.|
    /// </summary>
    [IsoId("_UFK5dW99EeKuY41pq1-dog")]
    [DisplayName("Unfranked Amount Per Security")]
    [IsoXmlTag("UfrnkdAmtPerScty")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? UnfrankedAmountPerSecurity { get; init; } 
    
    /// <summary>
    /// Conduit foreign income (CFI) amount related to the corporate action.
    /// </summary>
    [IsoId("_UFK5hG99EeKuY41pq1-dog")]
    [DisplayName("Conduit Foreign Income Amount")]
    [IsoXmlTag("CndtFrgnIncmAmt")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? ConduitForeignIncomeAmount { get; init; } 
    
    
    #nullable disable
    
}
