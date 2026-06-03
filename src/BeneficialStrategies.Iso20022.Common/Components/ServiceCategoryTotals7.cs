// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals per service category.
/// </summary>
[IsoId("_xSxKsUw0EfCpsI1b9uv5FQ")]
[DisplayName("Service Category Totals7")]
public record ServiceCategoryTotals7
{
    [IsoId("_xSxKtUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Billed Customer Identification")]
    [IsoXmlTag("BllgCstmrId")]
    public PartyIdentification136? BilledCustomerIdentification { get; init; }

    [IsoId("_xSxKuUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<BillingTaxRecord2> Tax { get; init; } = [];

    [IsoId("_xSxKvUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required AmountAndForeignExchange1 TotalInvoiceAmount { get; init; }

    [IsoId("_xSxKwUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Category")]
    [IsoXmlTag("SvcCtgy")]
    public required ServiceCategory1Choice_ ServiceCategory { get; init; }

    [IsoId("_xSxKxUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Item Totals")]
    [IsoXmlTag("SvcItmTtls")]
    public ValueList<ServiceItemTotals10> ServiceItemTotals { get; init; } = [];

    [IsoId("_xSxKyUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Item Correction")]
    [IsoXmlTag("SvcItmCrrctn")]
    public ValueList<ServiceItemTotals11> ServiceItemCorrection { get; init; } = [];
}
