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
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities&apos; receipts minus the sum of securities&apos; deliveries.
/// </summary>
[IsoId("_R_vBItp-Ed-ak6NoX_4Aeg_-536015669")]
[DisplayName("Aggregate Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalanceInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalanceInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalanceInformation3( BalanceQuantity1Choice_ reqAggregateQuantity,FinancialInstrument13 reqFinancialInstrumentDetails )
    {
        AggregateQuantity = reqAggregateQuantity;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_R_vBI9p-Ed-ak6NoX_4Aeg_-536015626")]
    [DisplayName("Aggregate Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtQty")]
    #endif
    [IsoXmlTag("AggtQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    #else
    public BalanceQuantity1Choice_ AggregateQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_R_vBJNp-Ed-ak6NoX_4Aeg_-536015609")]
    [DisplayName("Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DaysAcrd")]
    #endif
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysAccrued { get; init; } 
    #else
    public System.UInt64? DaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R_vBJdp-Ed-ak6NoX_4Aeg_-536015591")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> HoldingValue { get; init; } = new ValueList<ActiveOrHistoricCurrencyAndAmount>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_vBJdp-Ed-ak6NoX_4Aeg_-536015591
    
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R_vBJtp-Ed-ak6NoX_4Aeg_-1435791809")]
    [DisplayName("Previous Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsHldgVal")]
    #endif
    [IsoXmlTag("PrvsHldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_R_vBJ9p-Ed-ak6NoX_4Aeg_-536015574")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    [IsoId("_R_vBKNp-Ed-ak6NoX_4Aeg_1557340678")]
    [DisplayName("Accrued Interest Amount Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmtSgn")]
    #endif
    [IsoXmlTag("AcrdIntrstAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccruedInterestAmountSign { get; init; } 
    #else
    public System.String? AccruedInterestAmountSign { get; set; } 
    #endif
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_R_vBKdp-Ed-ak6NoX_4Aeg_-536015556")]
    [DisplayName("Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookVal")]
    #endif
    [IsoXmlTag("BookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_R_vBKtp-Ed-ak6NoX_4Aeg_-536015514")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Security held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_R_vBK9p-Ed-ak6NoX_4Aeg_-536014790")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument13 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_R_4yINp-Ed-ak6NoX_4Aeg_-536014816")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation2> PriceDetails { get; init; } = new ValueList<PriceInformation2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R_4yINp-Ed-ak6NoX_4Aeg_-536014816
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_R_4yIdp-Ed-ak6NoX_4Aeg_-536014850")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R_4yItp-Ed-ak6NoX_4Aeg_-536015176")]
    [DisplayName("Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalBrkdwnDtls")]
    #endif
    [IsoXmlTag("BalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    #else
    public SubBalanceInformation2? BalanceBreakdownDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R_4yI9p-Ed-ak6NoX_4Aeg_-536015193")]
    [DisplayName("Additional Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwnDtls")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
    /// </summary>
    [IsoId("_R_4yJNp-Ed-ak6NoX_4Aeg_-536015141")]
    [DisplayName("Balance At Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAtSfkpgPlc")]
    #endif
    [IsoXmlTag("BalAtSfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalancePerSafekeepingPlace4? BalanceAtSafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalancePerSafekeepingPlace4? BalanceAtSafekeepingPlace { get; init; } 
    #else
    public AggregateBalancePerSafekeepingPlace4? BalanceAtSafekeepingPlace { get; set; } 
    #endif
    
    
    #nullable disable
    
}
