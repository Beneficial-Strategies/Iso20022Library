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
/// Valuation details of each piece of collateral posted.
/// </summary>
[IsoId("_eJF90SqUEeyR9JrVGfaMKw")]
[DisplayName("Collateral Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValuation13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValuation13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValuation13( CollateralType8Code reqCollateralType,SettlementStatus3Code reqSettlementStatus,CollateralAmount1 reqValuationAmounts )
    {
        CollateralType = reqCollateralType;
        SettlementStatus = reqSettlementStatus;
        ValuationAmounts = reqValuationAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the valued collateral.
    /// </summary>
    [IsoId("_eg72ESqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollId")]
    #endif
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIdentification { get; init; } 
    #else
    public System.String? CollateralIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral used.
    /// </summary>
    [IsoId("_eg72EyqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralType8Code CollateralType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralType8Code CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType8Code CollateralType { get; init; } 
    #else
    public CollateralType8Code CollateralType { get; set; } 
    #endif
    
    /// <summary>
    /// Direction of the collateral being reported.
    /// </summary>
    [IsoId("_eg72FSqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollDrctn")]
    #endif
    [IsoXmlTag("CollDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralDirection1Code? CollateralDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralDirection1Code? CollateralDirection { get; init; } 
    #else
    public CollateralDirection1Code? CollateralDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement status of the instruction/financial instrument movement.
    /// </summary>
    [IsoId("_eg72FyqUEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStatus3Code SettlementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStatus3Code SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus3Code SettlementStatus { get; init; } 
    #else
    public SettlementStatus3Code SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the collateral being reported is applied or in excess.
    /// </summary>
    [IsoId("_eg72GSqUEeyR9JrVGfaMKw")]
    [DisplayName("Applied Excess Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApldXcssInd")]
    #endif
    [IsoXmlTag("ApldXcssInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAppliedExcess1Code? AppliedExcessIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAppliedExcess1Code? AppliedExcessIndicator { get; init; } 
    #else
    public CollateralAppliedExcess1Code? AppliedExcessIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days used for interest calculation.
    /// </summary>
    [IsoId("_eg72GyqUEeyR9JrVGfaMKw")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the collateral valuation.
    /// </summary>
    [IsoId("_eg72HSqUEeyR9JrVGfaMKw")]
    [DisplayName("Valuation Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmts")]
    #endif
    [IsoXmlTag("ValtnAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount1 ValuationAmounts { get; init; } 
    #else
    public CollateralAmount1 ValuationAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_eg72HyqUEeyR9JrVGfaMKw")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethod2Code? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    [IsoId("_eg72ISqUEeyR9JrVGfaMKw")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_eg72IyqUEeyR9JrVGfaMKw")]
    [DisplayName("Currency Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyHrcut")]
    #endif
    [IsoXmlTag("CcyHrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrencyHaircut { get; init; } 
    #else
    public System.Decimal? CurrencyHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    [IsoId("_eg72JSqUEeyR9JrVGfaMKw")]
    [DisplayName("Adjusted Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdRate")]
    #endif
    [IsoXmlTag("AdjstdRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AdjustedRate { get; init; } 
    #else
    public System.Decimal? AdjustedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    [IsoId("_eg72JyqUEeyR9JrVGfaMKw")]
    [DisplayName("Securities Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesColl")]
    #endif
    [IsoXmlTag("SctiesColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCollateral13? SecuritiesCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCollateral13? SecuritiesCollateral { get; init; } 
    #else
    public SecuritiesCollateral13? SecuritiesCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the cash collateral valuation.
    /// </summary>
    [IsoId("_eg72KSqUEeyR9JrVGfaMKw")]
    [DisplayName("Cash Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshColl")]
    #endif
    [IsoXmlTag("CshColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCollateral4? CashCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCollateral4? CashCollateral { get; init; } 
    #else
    public CashCollateral4? CashCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Details of other collateral.
    /// </summary>
    [IsoId("_eg72KyqUEeyR9JrVGfaMKw")]
    [DisplayName("Other Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrColl")]
    #endif
    [IsoXmlTag("OthrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCollateral10? OtherCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCollateral10? OtherCollateral { get; init; } 
    #else
    public OtherCollateral10? OtherCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
