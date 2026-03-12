// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the reported transaction.
/// </summary>
[IsoId("_R8SRQZifEe2f7NHvXATP5g")]
[DisplayName("Securities Transaction")]
public partial record SecuritiesTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_R9dV8ZifEe2f7NHvXATP5g")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TradeDate { get; init; } 
    
    /// <summary>
    /// Indication of whether the transaction results from the reporting firm carrying out matched principal trading or dealing on own account under the local regulation, or where the transaction does not result from the reporting firm carrying out matched principal trading or dealing on own account, the field shall indicate that the transaction was carried out under any other capacity.
    /// </summary>
    [IsoId("_R9dV9ZifEe2f7NHvXATP5g")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required RegulatoryTradingCapacity1Code TradingCapacity { get; init; } 
    
    /// <summary>
    /// Number of units of the financial instrument, or the number of derivative contracts in the transaction.
    /// </summary>
    [IsoId("_R9dV95ifEe2f7NHvXATP5g")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity25Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Number of token units of a tokenised financial instrument.
    /// </summary>
    [IsoId("_IvEBUKOjEe2UDKy7o9_HIg")]
    [DisplayName("Digital Token Quantity")]
    [IsoXmlTag("DgtlTknQty")]
    public DigitalTokenAmount2? DigitalTokenQuantity { get; init; } 
    
    /// <summary>
    /// Indicates as to whether an increase or a decrease of notional of derivative contracts has taken place.
    /// </summary>
    [IsoId("_R9dV-ZifEe2f7NHvXATP5g")]
    [DisplayName("Derivative Notional Change")]
    [IsoXmlTag("DerivNtnlChng")]
    public VariationType1Code? DerivativeNotionalChange { get; init; } 
    
    /// <summary>
    /// Traded price of the transaction excluding, where applicable, commission and accrued interest.
    /// In the case of option contracts, it is the premium of the derivative contract per underlying security or index point.
    /// In the case of spread bets it should be the reference price of the direct underlying instrument.
    /// Where price is currently not available but pending, the value should be ’PNDG’.
    /// For CDS it should be the coupon in basis points. 
    /// Where price reported in monetary terms, it shall be provided in the major currency unit.
    /// Where price is not applicable the field should be left blank.
    /// </summary>
    [IsoId("_R9dV-5ifEe2f7NHvXATP5g")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public required SecuritiesTransactionPrice22Choice_ Price { get; init; } 
    
    /// <summary>
    /// Net amount of the transaction means the cash amount which is paid by the buyer of the debt instrument upon the settlement of the transaction.
    /// </summary>
    [IsoId("_R9dV_ZifEe2f7NHvXATP5g")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Identification of the venue where the transaction was executed.
    /// Usage: 
    /// Use the ISO 10383 segment MIC (4 characters) for financial instruments executed on a MiFID trading venue, System Internaliser (SI) or non-EU organised trading platform. Where the segment MIC does not exist, use the operating MIC. 
    /// Use MIC code ‘XOFF’ for financial instruments admitted to trading or traded on a trading venue, where the transaction on that financial instrument is not executed on a MiFID trading venue, SI or non-EU organised trading platform, or where an investment firm does not know it is trading with another investment firm acting as an SI.
    /// Use MIC code ‘XXXX’ for financial instruments that are not admitted to trading or traded on a trading venue or for which no request for admission has been made and that are not traded on an non-EU organised trading platform but where the underlying is admitted to trading or traded on a trading venue.
    /// </summary>
    [IsoId("_R9dV_5ifEe2f7NHvXATP5g")]
    [DisplayName("Trade Venue")]
    [IsoXmlTag("TradVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier TradeVenue { get; init; } 
    
    /// <summary>
    /// Country of the branch of the investment firm whose market membership was used to execute the transaction.
    /// TBC with item 46.
    /// </summary>
    [IsoId("_R9dWAZifEe2f7NHvXATP5g")]
    [DisplayName("Country Of Branch")]
    [IsoXmlTag("CtryOfBrnch")]
    public CountryCode? CountryOfBranch { get; init; } 
    
    /// <summary>
    /// Monetary value of any up-front payment in basis points of notional received or paid by the seller.
    /// Where the seller receives the up-front payment, the value populated is positive. Where the seller pays the up-front payment, the value populated is negative.
    /// For increase or decrease in notional derivative contracts, the number shall reflect the absolute value of the change and shall be expressed as a positive number.
    /// </summary>
    [IsoId("_R9dWA5ifEe2f7NHvXATP5g")]
    [DisplayName("Up Front Payment")]
    [IsoXmlTag("UpFrntPmt")]
    public AmountAndDirection53? UpFrontPayment { get; init; } 
    
    /// <summary>
    /// Common matching identification when executed on a trade place.
    /// Usage: Must be present when a trade venue has been provided.
    /// </summary>
    [IsoId("_R9dWBZifEe2f7NHvXATP5g")]
    [DisplayName("Trade Place Matching Identification")]
    [IsoXmlTag("TradPlcMtchgId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? TradePlaceMatchingIdentification { get; init; } 
    
    /// <summary>
    /// Identification, internal to the reporting party to identify all the reports related to the same execution of a combination of financial instruments. The code must be unique for the reporting party for the group of reports for the execution.
    /// Usage:
    /// Field only applies when the instrument is complex.
    /// </summary>
    [IsoId("_R9dWB5ifEe2f7NHvXATP5g")]
    [DisplayName("Complex Trade Component Identification")]
    [IsoXmlTag("CmplxTradCmpntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ComplexTradeComponentIdentification { get; init; } 
    
    
    #nullable disable
    
}
