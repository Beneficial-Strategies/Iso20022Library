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
[IsoId("96921b4a-6149-4783-b0f3-c8cf02056280")]
[DisplayName("Redemption Multiple Execution07")]
public record RedemptionMultipleExecution07
{
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("02c06fad-80de-4f20-bc5c-31115ea94736")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party.
    /// </summary>
    [IsoId("388ae1d9-84a4-47a5-a696-1bd317872bf6")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("6ba2fb30-736b-4b4b-bab7-d39744ec61d1")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("35a22808-6c5f-4ee7-bc76-f5bc939d9bb7")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party.
    /// </summary>
    [IsoId("a9053750-9f5b-4aa2-abe2-9f9c567a710f")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.
    /// </summary>
    [IsoId("47a67305-2a86-4f08-b905-afea293d5806")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("3e7cc95e-6a8b-4e31-9dba-740fc28a5aef")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("22c739b7-c648-4efd-a856-26931cda4342")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("a9760607-2456-46c9-b185-5bbdfe1d0d41")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    [IsoId("9c09d425-c3d8-459e-a441-11285a195946")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    [MinLength(1)]
    public ValueList<RedemptionExecution19> IndividualExecutionDetails { get; init; } = [];

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("2a64ac0a-35ee-4148-8d13-9a398f0ae71f")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("02307ee8-caf1-4bc6-b44a-46413f351adb")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction167? BulkCashSettlementDetails { get; init; }
}
