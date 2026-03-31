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
[IsoId("_G7y2HzbtEead9bDRE_1DAQ")]
[DisplayName("Subscription Multiple Execution")]
public record SubscriptionMultipleExecution5
{
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("_eovmcVALEeal4_lvhAnyGQ")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_HUyknTbtEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_HUyknzbtEead9bDRE_1DAQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("_HUykoTbtEead9bDRE_1DAQ")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party, for example, the transfer agent.
    /// </summary>
    [IsoId("_wP-GADw6Eea0R-RTP9Wg-Q")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_HUykozbtEead9bDRE_1DAQ")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("_0hD3IThdEeamLZQeccJa7w")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("_HUykqTbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_HUykqzbtEead9bDRE_1DAQ")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("_HUykrTbtEead9bDRE_1DAQ")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<SubscriptionExecution13> IndividualExecutionDetails { get; init; } = [];

    // ID for the above is _HUykrTbtEead9bDRE_1DAQ

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_HUykrzbtEead9bDRE_1DAQ")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_HUykszbtEead9bDRE_1DAQ")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction70? BulkCashSettlementDetails { get; init; }
}
