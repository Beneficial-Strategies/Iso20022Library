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
[IsoId("fb1d61fe-98ad-4a4c-96a2-9349c92eb6f1")]
[DisplayName("Subscription Multiple Order7")]
public record SubscriptionMultipleOrder7
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("7792d5c7-cac8-4b91-ac21-9c4b6ad44f5d")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("225ac8c2-0eb6-4f75-9ea5-542f8b74617b")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("79872c3b-16d2-4e63-a377-4bfe1e61d945")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("6f5eabcc-be3b-43d0-8dec-ffb18b6206d7")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTime2Choice_? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed. The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("efca429b-a481-4ace-93b3-5b523911c923")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("5dacb04c-da03-456a-ab0e-ff298090fd90")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("52878e33-2251-498d-a770-802c28987b6c")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("a5695908-5e63-4d76-bf44-c83adcfd72b2")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson31> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Order to invest the investor's principal in an investment fund.
    /// </summary>
    [IsoId("6c9fa652-b2d6-408e-8310-852b6b602b2c")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    [MinLength(1)]
    public ValueList<SubscriptionOrder17> IndividualOrderDetails { get; init; } = [];

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("c4c1d9b5-1873-41a1-a240-9bb4f969f5f6")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction180? BulkCashSettlementDetails { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("cc6f7247-5617-4d84-8d61-2c5954e888d1")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }
}
