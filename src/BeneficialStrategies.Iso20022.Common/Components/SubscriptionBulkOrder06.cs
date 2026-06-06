// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor's principal in an investment fund.
/// </summary>
[IsoId("9563f788-9e57-423d-ab56-b2fd1dc4aa00")]
[DisplayName("Subscription Bulk Order06")]
public record SubscriptionBulkOrder06
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("d27feea7-2599-4401-8d3d-4f8f04a26500")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("36072695-e47e-4ac5-a5f1-17b973e3353a")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("f19a8eaa-3b6e-4760-b87f-7db32cbfcdfc")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("dd896ca9-93b6-4589-8589-ad0a69ebebc7")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTime2Choice_? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.
    /// </summary>
    [IsoId("713ddfb0-9437-4e97-aa78-bdc18b25f3a8")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("ebe3b1d9-f4ae-4148-a1ca-5830de7e1014")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    [IsoId("9e14fbf2-ddde-42c6-bd2a-9ec795540ce6")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Order to invest the investor's principal in an investment fund.
    /// </summary>
    [IsoId("11426ac8-5b97-4e12-9b59-bd85b3f931fe")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    [MinLength(1)]
    public ValueList<SubscriptionOrder16> IndividualOrderDetails { get; init; } = [];

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("0566ced0-e0d0-44b3-8005-1c4688190bf1")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("df2d6159-19bb-43f2-af04-753b4262427d")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("93d59d8b-c94d-47d4-910e-5568290edd8a")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("75bd6232-3ee6-4cef-83d8-608663adc824")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction180? BulkCashSettlementDetails { get; init; }
}
