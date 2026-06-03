// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("01df61c8-aa31-4aa7-8207-0c0029ff8f76")]
[DisplayName("Redemption Multiple Order07")]
public record RedemptionMultipleOrder07
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party.
    /// </summary>
    [IsoId("c0d8f102-af1a-450b-a2f7-1cd5e79873c0")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("ac80d0b2-ac31-487b-b918-d2035147f2a8")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("fa3c5103-fabe-484e-9936-c7b1b1c29eca")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("91869a40-cb68-43b9-9557-82c5f7139627")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTime2Choice? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.
    /// </summary>
    [IsoId("27efb0a7-e4c2-4422-a21f-424ccdef6605")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("32a66a2f-9c33-424e-8c89-7de46500132a")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("38ac13fb-9252-444c-9b2d-e45781db2069")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("98b3b69e-e2e8-4651-9638-3418b345b59a")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("6a40aada-d00e-46bb-b97c-e1863f6d643d")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    [MinLength(1)]
    public ValueList<RedemptionOrder18> IndividualOrderDetails { get; init; } = [];

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("97f17295-794e-4542-b1dc-b7ac9a1e3c4d")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction167? BulkCashSettlementDetails { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("3d079c20-dac2-4bc8-933d-7c0c58a24e48")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }
}
