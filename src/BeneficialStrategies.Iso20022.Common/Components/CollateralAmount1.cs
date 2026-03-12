// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the collateral valuation such as the collateral amount, the market value.
/// </summary>
[IsoId("_vWhlQ6MOEeCojJW5vEuTEQ_1855607436")]
[DisplayName("Collateral Amount")]
public partial record CollateralAmount1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total amount of the collateral in the collateral currency.
    /// </summary>
    [IsoId("_vWhlRKMOEeCojJW5vEuTEQ_14047154")]
    [DisplayName("Collateral Amount")]
    [IsoXmlTag("CollAmt")]
    public required ActiveCurrencyAndAmount CollateralAmount { get; init; } 
    
    /// <summary>
    /// Specifies the total amount of the collateral in the reporting currency.
    /// </summary>
    [IsoId("_vWhlRaMOEeCojJW5vEuTEQ_-838505809")]
    [DisplayName("Reported Currency And Amount")]
    [IsoXmlTag("RptdCcyAndAmt")]
    public required ActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; init; } 
    
    /// <summary>
    /// Specifies the total market to market value of the collateral in the reporting currency. It is the dirty price, that is, the accrued interest is included if any.
    /// </summary>
    [IsoId("_vWhlRqMOEeCojJW5vEuTEQ_-509144164")]
    [DisplayName("Market Value Amount")]
    [IsoXmlTag("MktValAmt")]
    public required ActiveCurrencyAndAmount MarketValueAmount { get; init; } 
    
    /// <summary>
    /// Specifies the accrued interest on the value of the collateral in the currency of the collateral.
    /// </summary>
    [IsoId("_vWhlR6MOEeCojJW5vEuTEQ_2039101812")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money paid for the provision of financial services.
    /// </summary>
    [IsoId("_vWqvMKMOEeCojJW5vEuTEQ_-1928237919")]
    [DisplayName("Fees And Commissions")]
    [IsoXmlTag("FeesAndComssns")]
    public ActiveCurrencyAndAmount? FeesAndCommissions { get; init; } 
    
    
    #nullable disable
    
}
