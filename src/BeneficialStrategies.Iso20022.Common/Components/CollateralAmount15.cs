// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral valuation.
/// </summary>
[IsoId("_1-cboRIlEeyLzJfz3xPQNA")]
[DisplayName("Collateral Amount")]
public partial record CollateralAmount15
{
    #nullable enable
    
    /// <summary>
    /// Total value of posted collateral (post-haircut) expressed in the reporting currency.
    /// </summary>
    [IsoId("_2V1n8xIlEeyLzJfz3xPQNA")]
    [DisplayName("Value Of Collateral Held")]
    [IsoXmlTag("ValOfCollHeld")]
    public required ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; } 
    
    /// <summary>
    /// Total exposure amount between the giver and taker expressed in the reporting currency.
    /// </summary>
    [IsoId("_2V1n9RIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Exposure")]
    [IsoXmlTag("TtlXpsr")]
    public required ActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; } 
    
    /// <summary>
    /// The difference between the total collateral value and the total collateral required.
    /// </summary>
    [IsoId("_2V1n9xIlEeyLzJfz3xPQNA")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection53? Margin { get; init; } 
    
    /// <summary>
    /// Collateral is required to cover interest that accrues on the exposure. Margin amount would thus be the difference between collateral required and collateral value (that is COVA).
    /// </summary>
    [IsoId("_2V1n-RIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Collateral Required")]
    [IsoXmlTag("TtlCollReqrd")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; init; } 
    
    /// <summary>
    /// Total amount of money accrued interest computed in the case of interest bearing financial instruments.
    /// </summary>
    [IsoId("_2V1n-xIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Accrued Interest")]
    [IsoXmlTag("TtlAcrdIntrst")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; init; } 
    
    /// <summary>
    /// Total fees/commissions in the reporting currency.
    /// </summary>
    [IsoId("_2V1n_RIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Fees Commissions")]
    [IsoXmlTag("TtlFeesComssns")]
    public ActiveOrHistoricCurrencyAndAmount? TotalFeesCommissions { get; init; } 
    
    /// <summary>
    /// Total of principals in the reporting currency.
    /// </summary>
    [IsoId("_2V1n_xIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Of Principals")]
    [IsoXmlTag("TtlOfPrncpls")]
    public ActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; init; } 
    
    /// <summary>
    /// Value of incoming collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_2V1oARIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Pending Collateral In")]
    [IsoXmlTag("TtlPdgCollIn")]
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; init; } 
    
    /// <summary>
    /// Value of outgoing collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_2V1oAxIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Pending Collateral Out")]
    [IsoXmlTag("TtlPdgCollOut")]
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; init; } 
    
    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [IsoId("_2V1oBRIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Value Of Own Collateral")]
    [IsoXmlTag("TtlValOfOwnColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    
    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [IsoId("_2V1oBxIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Value Of Reused Collateral")]
    [IsoXmlTag("TtlValOfReusdColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    
    /// <summary>
    /// Total value of undelivered intended transaction cash amount.
    /// </summary>
    [IsoId("_2V1oCRIlEeyLzJfz3xPQNA")]
    [DisplayName("Total Cash Failed")]
    [IsoXmlTag("TtlCshFaild")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; init; } 
    
    
    #nullable disable
    
}
