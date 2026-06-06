// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals per service item correction.
/// </summary>
[IsoId("_xWmh0Uw0EfCpsI1b9uv5FQ")]
[DisplayName("Service Item Totals11")]
public record ServiceItemTotals11
{
    /// <summary>
    /// Specifies a classification for the service items such as query, report, securities account, etc.
    /// </summary>
    [IsoId("_xWmh1Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Item Type")]
    [IsoXmlTag("ItmTp")]
    public required IsoMax20AlphaNumericText ItemType { get; init; }

    /// <summary>
    /// Description of the service item.
    /// </summary>
    [IsoId("_xWmh2Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Specifies whether the correction is a debit or credit.
    /// </summary>
    [IsoId("_xWmh3Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Sum of total number units per service item.
    /// </summary>
    [IsoId("_xWmh4Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required IsoNumber Quantity { get; init; }

    /// <summary>
    /// Currency of the balance. Should be present only if quantity is a balance.
    /// </summary>
    [IsoId("_xWmh5Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Balance Currency")]
    [IsoXmlTag("BalCcy")]
    public ActiveCurrencyCode? BalanceCurrency { get; init; }

    /// <summary>
    /// Specifies the price per unit of the service item.
    /// </summary>
    [IsoId("_xWmh6Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ActiveCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Detailed information on tax applied.
    /// </summary>
    [IsoId("_xWmh7Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<BillingTaxRecord2> Tax { get; init; } = [];

    /// <summary>
    /// Total amount of the invoice.
    /// </summary>
    [IsoId("_xWmh8Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required AmountAndForeignExchange1 TotalInvoiceAmount { get; init; }
}
