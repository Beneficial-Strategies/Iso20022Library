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
/// Provides details about the valuation of each piece of collateral that is posted.
/// </summary>
[IsoId("_7ZNbl2A4EeSMf75YyPqG7w")]
[DisplayName("Collateral Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValuation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValuation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValuation2( CollateralType1Code reqCollateralType,SettlementStatus2Code reqSettlementStatus,System.UInt64 reqNumberOfDaysAccrued,CollateralAmount1 reqValuationAmounts,InterestComputationMethod2Code reqDayCountBasis )
    {
        CollateralType = reqCollateralType;
        SettlementStatus = reqSettlementStatus;
        NumberOfDaysAccrued = reqNumberOfDaysAccrued;
        ValuationAmounts = reqValuationAmounts;
        DayCountBasis = reqDayCountBasis;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the valued collateral.
    /// </summary>
    [IsoId("_73G4gWA4EeSMf75YyPqG7w")]
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
    /// Specifies the type of collateral used.
    /// </summary>
    [IsoId("_73G4g2A4EeSMf75YyPqG7w")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralType1Code CollateralType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralType1Code CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType1Code CollateralType { get; init; } 
    #else
    public CollateralType1Code CollateralType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [IsoId("_73G4hWA4EeSMf75YyPqG7w")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStatus2Code SettlementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStatus2Code SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus2Code SettlementStatus { get; init; } 
    #else
    public SettlementStatus2Code SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for interest calculation.
    /// </summary>
    [IsoId("_73G4h2A4EeSMf75YyPqG7w")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDaysAccrued { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64 NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_73G4iWA4EeSMf75YyPqG7w")]
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
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_73G4i2A4EeSMf75YyPqG7w")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestComputationMethod2Code DayCountBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestComputationMethod2Code DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod2Code DayCountBasis { get; init; } 
    #else
    public InterestComputationMethod2Code DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    [IsoId("_73G4jWA4EeSMf75YyPqG7w")]
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
    /// Specifies the haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_73G4j2A4EeSMf75YyPqG7w")]
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
    [IsoId("_73G4kWA4EeSMf75YyPqG7w")]
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
    [IsoId("_73G4k2A4EeSMf75YyPqG7w")]
    [DisplayName("Securities Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesColl")]
    #endif
    [IsoXmlTag("SctiesColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCollateral2? SecuritiesCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCollateral2? SecuritiesCollateral { get; init; } 
    #else
    public SecuritiesCollateral2? SecuritiesCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the cash collateral valuation.
    /// </summary>
    [IsoId("_73G4lWA4EeSMf75YyPqG7w")]
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
    /// Provides details on other collateral valuation.
    /// </summary>
    [IsoId("_73G4l2A4EeSMf75YyPqG7w")]
    [DisplayName("Other Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrColl")]
    #endif
    [IsoXmlTag("OthrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCollateral3? OtherCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCollateral3? OtherCollateral { get; init; } 
    #else
    public OtherCollateral3? OtherCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
