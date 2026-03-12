// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QZqbNNp-Ed-ak6NoX_4Aeg_1800003201")]
[DisplayName("Aggregate Balance Information")]
public partial record AggregateBalanceInformation5
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_QZqbNdp-Ed-ak6NoX_4Aeg_1800003232")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_QZqbNtp-Ed-ak6NoX_4Aeg_1800003571")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_QZqbN9p-Ed-ak6NoX_4Aeg_1800003593")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_QZqbONp-Ed-ak6NoX_4Aeg_1800003685")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Investment fund class held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_QZ0MMNp-Ed-ak6NoX_4Aeg_1800004634")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument18 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_QZ0MMdp-Ed-ak6NoX_4Aeg_-1404422132")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public AdditionalBalanceInformation3? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Information relating to a sub balance of the investment fund.
    /// </summary>
    [IsoId("_QZ0MMtp-Ed-ak6NoX_4Aeg_1800924736")]
    [DisplayName("Sub Balance Information")]
    [IsoXmlTag("SubBalInf")]
    public SubBalanceInformation3? SubBalanceInformation { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument.
    /// </summary>
    [IsoId("_QZ0MM9p-Ed-ak6NoX_4Aeg_1800924674")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation3? PriceDetails { get; init; } 
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_QZ0MNNp-Ed-ak6NoX_4Aeg_-1563267664")]
    [DisplayName("Equalisation Balance")]
    [IsoXmlTag("EqulstnBal")]
    public Equalisation2? EqualisationBalance { get; init; } 
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_QZ0MNdp-Ed-ak6NoX_4Aeg_1800004271")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FrgnXchgDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    
    #nullable disable
    
}
