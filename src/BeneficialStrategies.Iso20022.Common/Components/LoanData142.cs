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
[IsoId("_IVzPgczwEeux2uvSBFU54Q")]
[DisplayName("Loan Data")]
public record LoanData142
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_IXw-YczwEeux2uvSBFU54Q")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_IXw-Y8zwEeux2uvSBFU54Q")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_IXw-ZczwEeux2uvSBFU54Q")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExecutionDateTime { get; init; }

    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_IXw-Z8zwEeux2uvSBFU54Q")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_IXw-aczwEeux2uvSBFU54Q")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    [IsoId("_IXw-a8zwEeux2uvSBFU54Q")]
    [DisplayName("Outstanding Margin Loan Amount")]
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; }

    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    [IsoId("_IXw-bczwEeux2uvSBFU54Q")]
    [DisplayName("Short Market Value Amount")]
    [IsoXmlTag("ShrtMktValAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; }

    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    [IsoId("_IXw-b8zwEeux2uvSBFU54Q")]
    [DisplayName("Margin Loan Attribute")]
    [IsoXmlTag("MrgnLnAttr")]
    public ValueList<InterestRate6> MarginLoanAttribute { get; init; } = [];

    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    [IsoId("_IXw-cczwEeux2uvSBFU54Q")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }
}
