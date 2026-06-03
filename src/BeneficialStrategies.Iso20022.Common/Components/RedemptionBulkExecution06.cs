// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("51275b2e-45a7-47a6-93bb-88d4326f8423")]
[DisplayName("Redemption Bulk Execution06")]
public record RedemptionBulkExecution06
{
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("081912ea-62d8-4982-9c38-20d209d06690")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party.
    /// </summary>
    [IsoId("e09171d3-dca0-4944-b8e7-d1072616bf4a")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("a5d8e1b7-4e2b-4e12-b2af-43292ba72d68")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("de44ce66-d6d1-4b13-81e8-28a2bd91420c")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party.
    /// </summary>
    [IsoId("bce5ce0c-a476-4823-9d40-39aa24b9887f")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.
    /// </summary>
    [IsoId("27656f65-6f00-4eea-946d-a21bc6c031a7")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("c8298d2b-3706-4e73-9c20-cadc8b8e21b4")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Investment fund class to which the investment fund order execution is related.
    /// </summary>
    [IsoId("d0926628-95f3-4b18-adaa-8959d24ccf2d")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    [IsoId("cf4601ac-ad1b-4bf4-a671-cc0d09d56312")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    [MinLength(1)]
    public ValueList<RedemptionExecution18> IndividualExecutionDetails { get; init; } = [];

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("140548fc-e828-40aa-899d-ce42d7fdd667")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund.
    /// </summary>
    [IsoId("9f22051e-0d8f-449b-b3d2-1b7133b97919")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("4ec3aa54-4672-41ae-b2ce-3499437a51c8")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("05c10967-74af-493c-8f5f-dc0ad9992821")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction167? BulkCashSettlementDetails { get; init; }
}
