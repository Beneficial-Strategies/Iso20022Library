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
    [IsoId("_xWmh1Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Item Type")]
    [IsoXmlTag("ItmTp")]
    public required IsoMax20AlphaNumericText ItemType { get; init; }

    [IsoId("_xWmh2Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax350Text? Description { get; init; }

    [IsoId("_xWmh3Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    [IsoId("_xWmh4Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required IsoNumber Quantity { get; init; }

    [IsoId("_xWmh5Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Balance Currency")]
    [IsoXmlTag("BalCcy")]
    public ActiveCurrencyCode? BalanceCurrency { get; init; }

    [IsoId("_xWmh6Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ActiveCurrencyAndAmount? UnitPrice { get; init; }

    [IsoId("_xWmh7Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<BillingTaxRecord2> Tax { get; init; } = [];

    [IsoId("_xWmh8Uw0EfCpsI1b9uv5FQ")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required AmountAndForeignExchange1 TotalInvoiceAmount { get; init; }
}
