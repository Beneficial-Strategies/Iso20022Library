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
[IsoId("_VXgOOdp-Ed-ak6NoX_4Aeg_1399796950")]
[DisplayName("Redemption Multiple Execution")]
public record RedemptionMultipleExecution2
{
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VXgOOtp-Ed-ak6NoX_4Aeg_995495680")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson2? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VXgOO9p-Ed-ak6NoX_4Aeg_1399797002")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VXp_MNp-Ed-ak6NoX_4Aeg_1399796968")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VXp_Mdp-Ed-ak6NoX_4Aeg_1399796985")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VXp_Mtp-Ed-ak6NoX_4Aeg_1399797295")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    [IsoId("_VXp_M9p-Ed-ak6NoX_4Aeg_1399797354")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<RedemptionExecution4> IndividualExecutionDetails { get; init; } = [];

    // ID for the above is _VXp_M9p-Ed-ak6NoX_4Aeg_1399797354

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VXp_NNp-Ed-ak6NoX_4Aeg_1399797311")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction15? BulkCashSettlementDetails { get; init; }
}
