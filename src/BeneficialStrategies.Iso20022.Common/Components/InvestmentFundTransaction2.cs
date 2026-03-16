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
[IsoId("_VGOQ-tp-Ed-ak6NoX_4Aeg_-1833771297")]
[DisplayName("Investment Fund Transaction")]
public record InvestmentFundTransaction2
{
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    [IsoId("_VGOQ-9p-Ed-ak6NoX_4Aeg_-697839942")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required TransactionType1CodeChoice_ TransactionType { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_VGOQ_Np-Ed-ak6NoX_4Aeg_-1862767787")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public required CorporateActionEventType1CodeChoice_ CorporateActionEventType { get; init; }

    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    [IsoId("_VGOQ_dp-Ed-ak6NoX_4Aeg_-690455186")]
    [DisplayName("Booking Status")]
    [IsoXmlTag("BookgSts")]
    public TransactionStatus1Code? BookingStatus { get; init; }

    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_VGOQ_tp-Ed-ak6NoX_4Aeg_-690455126")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique identifier for an order, as assigned by the sell-side. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_VGOQ_9p-Ed-ak6NoX_4Aeg_-690455056")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VGXa4Np-Ed-ak6NoX_4Aeg_-690454779")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VGXa4dp-Ed-ak6NoX_4Aeg_1094293937")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_VGXa4tp-Ed-ak6NoX_4Aeg_-1320347699")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VGXa49p-Ed-ak6NoX_4Aeg_1044421350")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Indicates whether the cash payment with respect to the executed order is settled.
    /// </summary>
    [IsoId("_VGXa5Np-Ed-ak6NoX_4Aeg_1044421410")]
    [DisplayName("Settled Transaction Indicator")]
    [IsoXmlTag("SttldTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SettledTransactionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the executed order has a registered status on the books of the transfer agent.
    /// </summary>
    [IsoId("_VGXa5dp-Ed-ak6NoX_4Aeg_25813824")]
    [DisplayName("Registered Transaction Indicator")]
    [IsoXmlTag("RegdTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegisteredTransactionIndicator { get; init; }

    /// <summary>
    /// Number of investment funds units.
    /// </summary>
    [IsoId("_VGXa5tp-Ed-ak6NoX_4Aeg_1272027096")]
    [DisplayName("Units Quantity")]
    [IsoXmlTag("UnitsQty")]
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; }

    /// <summary>
    /// Direction of the transaction being reported, ie, securities are received (credited) or delivered (debited).
    /// </summary>
    [IsoId("_VGXa59p-Ed-ak6NoX_4Aeg_-1179141618")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public required CreditDebitCode CreditDebit { get; init; }

    /// <summary>
    /// Transaction being reported is a reversal of previously reported transaction.
    /// </summary>
    [IsoId("_VGXa6Np-Ed-ak6NoX_4Aeg_-1585678185")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public ReversalCode? Reversal { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_VGXa6dp-Ed-ak6NoX_4Aeg_1272027390")]
    [DisplayName("Gross Settlement Amount")]
    [IsoXmlTag("GrssSttlmAmt")]
    public ActiveCurrencyAndAmount? GrossSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    [IsoId("_VGhL4Np-Ed-ak6NoX_4Aeg_1272027468")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VGhL4dp-Ed-ak6NoX_4Aeg_1272027793")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VGhL4tp-Ed-ak6NoX_4Aeg_1272027853")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_VGhL49p-Ed-ak6NoX_4Aeg_1272027948")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VGhL5Np-Ed-ak6NoX_4Aeg_-1538101759")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice1? PriceDetails { get; init; }
}
