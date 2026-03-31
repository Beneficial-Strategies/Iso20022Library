// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("_R3iuddp-Ed-ak6NoX_4Aeg_1894781569")]
[DisplayName("Subscription Multiple Execution")]
public record SubscriptionMultipleExecution3
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_R3iudtp-Ed-ak6NoX_4Aeg_-1342096602")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_R3iud9p-Ed-ak6NoX_4Aeg_1894782559")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_R3sfcNp-Ed-ak6NoX_4Aeg_1894784402")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_R3sfcdp-Ed-ak6NoX_4Aeg_1931009254")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_R3sfctp-Ed-ak6NoX_4Aeg_1895705674")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_R3sfc9p-Ed-ak6NoX_4Aeg_-2086862116")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; }

    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_R3sfdNp-Ed-ak6NoX_4Aeg_1855669393")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_R3sfddp-Ed-ak6NoX_4Aeg_1897552564")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson12? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("_R3sfdtp-Ed-ak6NoX_4Aeg_1898475061")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<SubscriptionExecution6> IndividualExecutionDetails { get; init; } = [];

    // ID for the above is _R3sfdtp-Ed-ak6NoX_4Aeg_1898475061

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_R3sfd9p-Ed-ak6NoX_4Aeg_1480301353")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_R3sfeNp-Ed-ak6NoX_4Aeg_1480301647")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_R3sfedp-Ed-ak6NoX_4Aeg_1898476614")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction24? BulkCashSettlementDetails { get; init; }
}
