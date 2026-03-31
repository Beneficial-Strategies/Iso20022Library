// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption Multiple Execution6.
/// </summary>
[IsoId("_oeOJYRwCEe6fEumgV5aG_A")]
[DisplayName("Redemption Multiple Execution6")]
public record RedemptionMultipleExecution6
{
    /// <summary>
    /// Amendment Indicator.
    /// </summary>
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Beneficiary Details.
    /// </summary>
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Bulk Cash Settlement Details.
    /// </summary>
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction151? BulkCashSettlementDetails { get; init; }

    /// <summary>
    /// Cancellation Right.
    /// </summary>
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Individual Execution Details.
    /// </summary>
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<RedemptionExecution17> IndividualExecutionDetails { get; init; } = [];

    /// <summary>
    /// Investment Account Details.
    /// </summary>
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount78 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Master Reference.
    /// </summary>
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Order Date Time.
    /// </summary>
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Received Date Time.
    /// </summary>
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Requested Future Trade Date.
    /// </summary>
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Total Settlement Amount.
    /// </summary>
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }
}
