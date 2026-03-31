// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
/// </summary>
[IsoId("_3zPtGQf9EeSaceXTzyiZRg")]
[DisplayName("Investment Fund Transaction")]
public record InvestmentFundTransaction4
{
    /// <summary>
    /// Underlying transaction or corporate action.
    /// </summary>
    [IsoId("_1FreEAf-EeSaceXTzyiZRg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required TransactionType1Choice_ EventType { get; init; }

    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    [IsoId("_4OBkkQf9EeSaceXTzyiZRg")]
    [DisplayName("Booking Status")]
    [IsoXmlTag("BookgSts")]
    public TransactionStatus1Code? BookingStatus { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_4OBkkwf9EeSaceXTzyiZRg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_4OBklQf9EeSaceXTzyiZRg")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_4OBklwf9EeSaceXTzyiZRg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_4OBkmQf9EeSaceXTzyiZRg")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_4OBkmwf9EeSaceXTzyiZRg")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_4OBknQf9EeSaceXTzyiZRg")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("_4OBknwf9EeSaceXTzyiZRg")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Indicates whether the cash payment with respect to the executed order is settled.
    /// </summary>
    [IsoId("_4OBkoQf9EeSaceXTzyiZRg")]
    [DisplayName("Settled Transaction Indicator")]
    [IsoXmlTag("SttldTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SettledTransactionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the executed order has a registered status on the books of the transfer agent.
    /// </summary>
    [IsoId("_4OBkowf9EeSaceXTzyiZRg")]
    [DisplayName("Registered Transaction Indicator")]
    [IsoXmlTag("RegdTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegisteredTransactionIndicator { get; init; }

    /// <summary>
    /// Number of investment funds units.
    /// </summary>
    [IsoId("_4OBkpQf9EeSaceXTzyiZRg")]
    [DisplayName("Units Quantity")]
    [IsoXmlTag("UnitsQty")]
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; }

    /// <summary>
    /// Direction of the transaction being reported, is, securities are received (credited) or delivered (debited).
    /// </summary>
    [IsoId("_4OBkpwf9EeSaceXTzyiZRg")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public required CreditDebitCode CreditDebit { get; init; }

    /// <summary>
    /// Transaction being reported is a reversal of previously reported transaction.
    /// </summary>
    [IsoId("_4OBkqQf9EeSaceXTzyiZRg")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public ReversalCode? Reversal { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_4OBkqwf9EeSaceXTzyiZRg")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    [IsoId("_4OBkrQf9EeSaceXTzyiZRg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_4OBkrwf9EeSaceXTzyiZRg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_4OBksQf9EeSaceXTzyiZRg")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_4OBkswf9EeSaceXTzyiZRg")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_4OBktQf9EeSaceXTzyiZRg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice20? PriceDetails { get; init; }
}
