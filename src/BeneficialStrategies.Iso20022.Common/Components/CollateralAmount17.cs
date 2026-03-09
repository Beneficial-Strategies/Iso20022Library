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
/// Provides details on the collateral valuation.
/// </summary>
[IsoId("_Spl8ARInEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAmount17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAmount17( ActiveOrHistoricCurrencyAndAmount reqValueOfCollateralHeld,ActiveOrHistoricCurrencyAndAmount reqTotalExposure )
    {
        ValueOfCollateralHeld = reqValueOfCollateralHeld;
        TotalExposure = reqTotalExposure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of posted collateral (post-haircut) expressed in the reporting currency.
    /// </summary>
    [IsoId("_TDEzARInEeyZaPkaPAzTvQ")]
    [DisplayName("Value Of Collateral Held")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValOfCollHeld")]
    #endif
    [IsoXmlTag("ValOfCollHeld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; set; } 
    #endif
    
    /// <summary>
    /// Total exposure amount between the giver and taker expressed in the reporting currency. It includes the transaction amount and the accrued interests minus any  unsettled amount.
    /// </summary>
    [IsoId("_TDEzAxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Exposure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlXpsr")]
    #endif
    [IsoXmlTag("TtlXpsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TotalExposure { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction Amount as instructed by the client. 
    /// </summary>
    [IsoId("_TDEzBRInEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of transaction amount (required value for the exposure)  into market value lots based on  the term for the underlying trades.
    /// </summary>
    [IsoId("_TDEzBxInEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmtBrkdwn")]
    #endif
    [IsoXmlTag("TxAmtBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralTransactionAmountBreakdown2? TransactionAmountBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralTransactionAmountBreakdown2? TransactionAmountBreakdown { get; init; } 
    #else
    public CollateralTransactionAmountBreakdown2? TransactionAmountBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// The difference between the total collateral value and the total collateral required.
    /// </summary>
    [IsoId("_TDEzCRInEeyZaPkaPAzTvQ")]
    [DisplayName("Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrgn")]
    #endif
    [IsoXmlTag("Mrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? Margin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? Margin { get; init; } 
    #else
    public AmountAndDirection53? Margin { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money accrued interest computed in the case of interest bearing financial instruments.
    /// </summary>
    [IsoId("_TDEzCxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Accrued Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAcrdIntrst")]
    #endif
    [IsoXmlTag("TtlAcrdIntrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral is required to cover interest that accrues on the exposure. Margin amount would thus be the difference between collateral required and collateral value (that is COVA).
    /// </summary>
    [IsoId("_TDEzDRInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Collateral Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCollReqrd")]
    #endif
    [IsoXmlTag("TtlCollReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [IsoId("_TDEzDxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Value Of Own Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlValOfOwnColl")]
    #endif
    [IsoXmlTag("TtlValOfOwnColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [IsoId("_TDEzERInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Value Of Reused Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlValOfReusdColl")]
    #endif
    [IsoXmlTag("TtlValOfReusdColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Value of incoming collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_TDEzExInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Pending Collateral In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgCollIn")]
    #endif
    [IsoXmlTag("TtlPdgCollIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; set; } 
    #endif
    
    /// <summary>
    /// Value of outgoing collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_TDEzFRInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Pending Collateral Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgCollOut")]
    #endif
    [IsoXmlTag("TtlPdgCollOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; set; } 
    #endif
    
    /// <summary>
    /// Total of principals in the reporting currency.
    /// </summary>
    [IsoId("_TDEzFxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Of Principals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOfPrncpls")]
    #endif
    [IsoXmlTag("TtlOfPrncpls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; set; } 
    #endif
    
    /// <summary>
    /// Termination Transaction Amount 
    /// </summary>
    [IsoId("_TDEzGRInEeyZaPkaPAzTvQ")]
    [DisplayName("Termination Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnTxAmt")]
    #endif
    [IsoXmlTag("TermntnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TerminationTransactionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of undelivered intended transaction cash amount.
    /// </summary>
    [IsoId("_TDEzGxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Cash Failed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCshFaild")]
    #endif
    [IsoXmlTag("TtlCshFaild")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; set; } 
    #endif
    
    
    #nullable disable
    
}
