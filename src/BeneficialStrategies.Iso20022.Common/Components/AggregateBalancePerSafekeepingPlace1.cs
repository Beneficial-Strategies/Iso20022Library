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
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_VLcIKtp-Ed-ak6NoX_4Aeg_1774314000")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalancePerSafekeepingPlace1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalancePerSafekeepingPlace1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalancePerSafekeepingPlace1( BalanceQuantity1Choice_ reqAggregateQuantity,SafekeepingPlaceFormatChoice_ reqSafekeepingPlace )
    {
        AggregateQuantity = reqAggregateQuantity;
        SafekeepingPlace = reqSafekeepingPlace;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_VLcIK9p-Ed-ak6NoX_4Aeg_-2028596341")]
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
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    [IsoId("_VLlSENp-Ed-ak6NoX_4Aeg_-2028596221")]
    [DisplayName("Available Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblQty")]
    #endif
    [IsoXmlTag("AvlblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    #else
    public BalanceQuantity1Choice_? AvailableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    [IsoId("_VLlSEdp-Ed-ak6NoX_4Aeg_-2028596126")]
    [DisplayName("Not Available Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotAvlblQty")]
    #endif
    [IsoXmlTag("NotAvlblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    #else
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_VLlSEtp-Ed-ak6NoX_4Aeg_-1353366144")]
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
    [IsoId("_VLlSE9p-Ed-ak6NoX_4Aeg_-1353365824")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VLlSFNp-Ed-ak6NoX_4Aeg_-1353365729")]
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
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VLlSFdp-Ed-ak6NoX_4Aeg_-1353365368")]
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
    [IsoId("_VLlSFtp-Ed-ak6NoX_4Aeg_1516698504")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_VLlSF9p-Ed-ak6NoX_4Aeg_-738225302")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation1? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation1? PriceDetails { get; init; } 
    #else
    public PriceInformation1? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_VLlSGNp-Ed-ak6NoX_4Aeg_-1691847513")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnXchgDtls")]
    #endif
    [IsoXmlTag("FrgnXchgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLlSGdp-Ed-ak6NoX_4Aeg_-985941865")]
    [DisplayName("Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalBrkdwnDtls")]
    #endif
    [IsoXmlTag("BalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation1? BalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation1? BalanceBreakdownDetails { get; init; } 
    #else
    public SubBalanceInformation1? BalanceBreakdownDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_VLvDENp-Ed-ak6NoX_4Aeg_-196328617")]
    [DisplayName("Additional Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwnDtls")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
