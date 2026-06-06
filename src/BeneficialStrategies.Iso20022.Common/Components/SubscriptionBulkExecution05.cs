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
[IsoId("d77f5252-15d2-450d-bbe7-bb05f028c6ac")]
[DisplayName("Subscription Bulk Execution05")]
public record SubscriptionBulkExecution05
{
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("51aaf6f5-efda-439a-8584-74a9fce34ef5")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("c5f689bc-f8f6-4c01-9f04-85656f748078")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("5977a524-826e-4588-a5a8-0067dc9581a0")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("f3c6ec2c-a46b-4d5d-b2ac-b622c7c87c9b")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party, for example, the transfer agent.
    /// </summary>
    [IsoId("dc5e7fda-e967-4a0a-83b8-3f29089e7e9a")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("78621f97-c912-45a4-8472-8e4989e223e9")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("2f93325c-aeef-413c-90b5-3ac7ada82796")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Investment fund class to which the investment fund order execution is related.
    /// </summary>
    [IsoId("f322dd00-02ed-4c2d-843f-c9c8a560c67e")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("30f6d7ec-367c-4e48-b813-d3e5c7cca191")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    [MinLength(1)]
    public ValueList<SubscriptionExecution15> IndividualExecutionDetails { get; init; } = [];

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("cc399d07-f936-4d9f-959c-6b8a14c09058")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("1c3f33c4-bf34-4bd3-9476-5a8cfb428906")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("ef78dc69-0aa8-4f43-ba0a-a49d7b904c3c")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("89aac5f6-7566-4c9a-9d70-b27dcf1c9f3c")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction180? BulkCashSettlementDetails { get; init; }
}
