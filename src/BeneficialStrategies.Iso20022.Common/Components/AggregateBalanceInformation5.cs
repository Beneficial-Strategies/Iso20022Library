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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QZqbNNp-Ed-ak6NoX_4Aeg_1800003201")]
[DisplayName("Aggregate Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateBalanceInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AggregateBalanceInformation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AggregateBalanceInformation5( BalanceQuantity1Choice_ reqAggregateQuantity,FinancialInstrument18 reqFinancialInstrumentDetails )
    {
        AggregateQuantity = reqAggregateQuantity;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_QZqbNdp-Ed-ak6NoX_4Aeg_1800003232")]
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
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_QZqbNtp-Ed-ak6NoX_4Aeg_1800003571")]
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
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_QZqbN9p-Ed-ak6NoX_4Aeg_1800003593")]
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
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_QZqbONp-Ed-ak6NoX_4Aeg_1800003685")]
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
    /// Investment fund class held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_QZ0MMNp-Ed-ak6NoX_4Aeg_1800004634")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument18 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument18 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument18 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument18 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_QZ0MMdp-Ed-ak6NoX_4Aeg_-1404422132")]
    [DisplayName("Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalBrkdwnDtls")]
    #endif
    [IsoXmlTag("BalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation3? BalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation3? BalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation3? BalanceBreakdownDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information relating to a sub balance of the investment fund.
    /// </summary>
    [IsoId("_QZ0MMtp-Ed-ak6NoX_4Aeg_1800924736")]
    [DisplayName("Sub Balance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalInf")]
    #endif
    [IsoXmlTag("SubBalInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubBalanceInformation3? SubBalanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceInformation3? SubBalanceInformation { get; init; } 
    #else
    public SubBalanceInformation3? SubBalanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the financial instrument.
    /// </summary>
    [IsoId("_QZ0MM9p-Ed-ak6NoX_4Aeg_1800924674")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation3? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation3? PriceDetails { get; init; } 
    #else
    public PriceInformation3? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_QZ0MNNp-Ed-ak6NoX_4Aeg_-1563267664")]
    [DisplayName("Equalisation Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnBal")]
    #endif
    [IsoXmlTag("EqulstnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Equalisation2? EqualisationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Equalisation2? EqualisationBalance { get; init; } 
    #else
    public Equalisation2? EqualisationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_QZ0MNdp-Ed-ak6NoX_4Aeg_1800004271")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnXchgDtls")]
    #endif
    [IsoXmlTag("FrgnXchgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
