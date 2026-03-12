// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_nh43Ya5MEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
public partial record ExposureMetrics4
{
    #nullable enable
    
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_nw8nEa5MEeuo-IflVgGqiA")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    
    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_nw8nE65MEeuo-IflVgGqiA")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_nw8nFa5MEeuo-IflVgGqiA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public AmountAndDirection53? MarketValue { get; init; } 
    
    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    [IsoId("_nw8nF65MEeuo-IflVgGqiA")]
    [DisplayName("Outstanding Margin Loan Amount")]
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    
    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    [IsoId("_nw8nGa5MEeuo-IflVgGqiA")]
    [DisplayName("Short Market Value Amount")]
    [IsoXmlTag("ShrtMktValAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    
    /// <summary>
    /// Margin loan in which a counterparty extends credit in connection with the purchase, sale, carrying or trading of securities, but not including other loans that are secured by collateral in the form of securities.
    /// </summary>
    [IsoId("_nw8nG65MEeuo-IflVgGqiA")]
    [DisplayName("Margin Loan")]
    [IsoXmlTag("MrgnLn")]
    public ActiveOrHistoricCurrencyAndAmount? MarginLoan { get; init; } 
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_nw8nHa5MEeuo-IflVgGqiA")]
    [DisplayName("Cash Collateral Amount")]
    [IsoXmlTag("CshCollAmt")]
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_nw8nH65MEeuo-IflVgGqiA")]
    [DisplayName("Collateral Market Value")]
    [IsoXmlTag("CollMktVal")]
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    
    
    #nullable disable
    
}
