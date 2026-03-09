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
/// Provides amounts taken in to account to calculate the collateral position.
/// </summary>
[IsoId("_vVx-YqMOEeCojJW5vEuTEQ_933225086")]
[DisplayName("Summary Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SummaryAmounts1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_AexcItokEeC60axPepSq7g_102667053")]
    [DisplayName("Threshold Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldAmt")]
    #endif
    [IsoXmlTag("ThrshldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ThresholdAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ThresholdAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ThresholdAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_vVx-Y6MOEeCojJW5vEuTEQ_-1456058639")]
    [DisplayName("Threshold Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldTp")]
    #endif
    [IsoXmlTag("ThrshldTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThresholdType1Code? ThresholdType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThresholdType1Code? ThresholdType { get; init; } 
    #else
    public ThresholdType1Code? ThresholdType { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of posted collateral (pre-haircut) held by the taker.
    /// </summary>
    [IsoId("_vVx-ZKMOEeCojJW5vEuTEQ_1210837912")]
    [DisplayName("Pre Haircut Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreHrcutCollVal")]
    #endif
    [IsoXmlTag("PreHrcutCollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreHaircutCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of collateral required (unrounded).
    /// </summary>
    [IsoId("_vVx-ZaMOEeCojJW5vEuTEQ_78396103")]
    [DisplayName("Adjusted Exposure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdXpsr")]
    #endif
    [IsoXmlTag("AdjstdXpsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AdjustedExposure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AdjustedExposure { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AdjustedExposure { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of collateral required (rounded).
    /// </summary>
    [IsoId("_vVx-ZqMOEeCojJW5vEuTEQ_1256493419")]
    [DisplayName("Collateral Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollReqrd")]
    #endif
    [IsoXmlTag("CollReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CollateralRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CollateralRequired { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CollateralRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of collateral).
    /// </summary>
    [IsoId("_vVx-Z6MOEeCojJW5vEuTEQ_-1634168070")]
    [DisplayName("Minimum Transfer Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTrfAmt")]
    #endif
    [IsoXmlTag("MinTrfAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumTransferAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumTransferAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumTransferAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_vVx-aKMOEeCojJW5vEuTEQ_344022506")]
    [DisplayName("Rounding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgAmt")]
    #endif
    [IsoXmlTag("RndgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RoundingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Exposure value at previous valuation.
    /// </summary>
    [IsoId("_vV7IUKMOEeCojJW5vEuTEQ_-1037937575")]
    [DisplayName("Previous Exposure Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsXpsrVal")]
    #endif
    [IsoXmlTag("PrvsXpsrVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreviousExposureValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreviousExposureValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreviousExposureValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral at previous valuation.
    /// </summary>
    [IsoId("_vV7IUaMOEeCojJW5vEuTEQ_-1492369915")]
    [DisplayName("Previous Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsCollVal")]
    #endif
    [IsoXmlTag("PrvsCollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreviousCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreviousCollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreviousCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of incoming collateral, to be settled.
    /// </summary>
    [IsoId("_vV7IUqMOEeCojJW5vEuTEQ_-2014052582")]
    [DisplayName("Total Pending Incoming Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgIncmgColl")]
    #endif
    [IsoXmlTag("TtlPdgIncmgColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Value of outgoing collateral, to be settled.
    /// </summary>
    [IsoId("_vV7IU6MOEeCojJW5vEuTEQ_-1006504724")]
    [DisplayName("Total Pending Outgoing Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgOutgngColl")]
    #endif
    [IsoXmlTag("TtlPdgOutgngColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of accrued interest.
    /// </summary>
    [IsoId("_vV7IVKMOEeCojJW5vEuTEQ_-1233182887")]
    [DisplayName("Total Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAcrdIntrstAmt")]
    #endif
    [IsoXmlTag("TtlAcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of fees/commissions.
    /// </summary>
    [IsoId("_vV7IVaMOEeCojJW5vEuTEQ_109882518")]
    [DisplayName("Total Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlFees")]
    #endif
    [IsoXmlTag("TtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalFees { get; set; } 
    #endif
    
    
    #nullable disable
    
}
