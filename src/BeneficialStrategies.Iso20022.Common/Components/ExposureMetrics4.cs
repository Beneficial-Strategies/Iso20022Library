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
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_nh43Ya5MEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExposureMetrics4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_nw8nEa5MEeuo-IflVgGqiA")]
    [DisplayName("Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmt")]
    #endif
    [IsoXmlTag("PrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    #else
    public PrincipalAmount3? PrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_nw8nE65MEeuo-IflVgGqiA")]
    [DisplayName("Loan Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnVal")]
    #endif
    [IsoXmlTag("LnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_nw8nFa5MEeuo-IflVgGqiA")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? MarketValue { get; init; } 
    #else
    public AmountAndDirection53? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    [IsoId("_nw8nF65MEeuo-IflVgGqiA")]
    [DisplayName("Outstanding Margin Loan Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngMrgnLnAmt")]
    #endif
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    [IsoId("_nw8nGa5MEeuo-IflVgGqiA")]
    [DisplayName("Short Market Value Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtMktValAmt")]
    #endif
    [IsoXmlTag("ShrtMktValAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Margin loan in which a counterparty extends credit in connection with the purchase, sale, carrying or trading of securities, but not including other loans that are secured by collateral in the form of securities.
    /// </summary>
    [IsoId("_nw8nG65MEeuo-IflVgGqiA")]
    [DisplayName("Margin Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnLn")]
    #endif
    [IsoXmlTag("MrgnLn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarginLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarginLoan { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarginLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_nw8nHa5MEeuo-IflVgGqiA")]
    [DisplayName("Cash Collateral Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCollAmt")]
    #endif
    [IsoXmlTag("CshCollAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    #else
    public AmountAndDirection53? CashCollateralAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_nw8nH65MEeuo-IflVgGqiA")]
    [DisplayName("Collateral Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMktVal")]
    #endif
    [IsoXmlTag("CollMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    #else
    public AmountAndDirection53? CollateralMarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
