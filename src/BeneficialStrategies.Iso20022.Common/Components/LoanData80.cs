// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a margin lending transaction.
/// </summary>
[IsoId("_g5iFAax2Eem81-uIvTF5rQ")]
[DisplayName("Loan Data")]
public record LoanData80
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_g9taYax2Eem81-uIvTF5rQ")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_g9taY6x2Eem81-uIvTF5rQ")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_g9taZax2Eem81-uIvTF5rQ")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; }

    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_qnka4cpiEem6kd3Y9uIDqg")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_g9taZ6x2Eem81-uIvTF5rQ")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    [IsoId("_g9taaax2Eem81-uIvTF5rQ")]
    [DisplayName("Outstanding Margin Loan Amount")]
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; }

    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    [IsoId("_g9taa6x2Eem81-uIvTF5rQ")]
    [DisplayName("Short Market Value Amount")]
    [IsoXmlTag("ShrtMktValAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; }

    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    [IsoId("_g9tab6x2Eem81-uIvTF5rQ")]
    [DisplayName("Margin Loan Attribute")]
    [IsoXmlTag("MrgnLnAttr")]
    public ValueList<InterestRate3> MarginLoanAttribute { get; init; } = [];

    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    [IsoId("_g9tacax2Eem81-uIvTF5rQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }
}
