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
[IsoId("d68e304c-a9ed-4f64-a365-aeb8fd627c4f")]
[DisplayName("Redemption Bulk Order08")]
public record RedemptionBulkOrder08
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party.
    /// </summary>
    [IsoId("464a7d79-5341-4ff6-98b0-974d4f2bb735")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("a667531c-46f6-4ebe-a99f-f1ec57cc9490")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("301b8e75-ee44-4b95-b27b-80f3c019e441")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("31a0dcc3-2da0-49ed-9cd5-8642e606bb77")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTime2Choice? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.
    /// </summary>
    [IsoId("85bdd338-a9ef-4a20-8370-3b89fcf07fd7")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("ca2e2c49-434e-431e-85b5-333ec215502e")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice? CancellationRight { get; init; }

    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    [IsoId("983a5a0c-7abf-403a-ab92-3c8b92b8bb65")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("15524a9f-2c91-43a5-91c5-2ea4cee3a101")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    [MinLength(1)]
    public ValueList<RedemptionOrder17> IndividualOrderDetails { get; init; } = [];

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("42c55b06-745d-416c-a42f-40cbda8fe738")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund.
    /// </summary>
    [IsoId("6661e262-1639-47fa-a702-6b4d391f936e")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("ac898f21-3d6b-4197-8e14-25b3433a1eb3")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("c0e36d8d-6b51-4623-bf55-b0321dd120b4")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction167? BulkCashSettlementDetails { get; init; }
}
