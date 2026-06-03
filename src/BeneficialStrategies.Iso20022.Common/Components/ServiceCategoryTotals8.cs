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
[IsoId("_xLEAMUw0EfCpsI1b9uv5FQ")]
[DisplayName("Service Category Totals8")]
public record ServiceCategoryTotals8
{
    [IsoId("_xLEANUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification38Choice? AccountIdentification { get; init; }

    [IsoId("_xLEAOUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Parent Account Identification")]
    [IsoXmlTag("PrntAcctId")]
    public AccountIdentification38Choice? ParentAccountIdentification { get; init; }

    [IsoId("_xLEAPUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Billed Customer Identification")]
    [IsoXmlTag("BllgCstmrId")]
    public PartyIdentification136? BilledCustomerIdentification { get; init; }

    [IsoId("_xLEAQUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<BillingTaxRecord2> Tax { get; init; } = [];

    [IsoId("_xLEARUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required AmountAndForeignExchange1 TotalInvoiceAmount { get; init; }

    [IsoId("_xLEASUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Category")]
    [IsoXmlTag("SvcCtgy")]
    public required ServiceCategory1Choice ServiceCategory { get; init; }

    [IsoId("_xLEATUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Item Totals")]
    [IsoXmlTag("SvcItmTtls")]
    public ValueList<ServiceItemTotals12> ServiceItemTotals { get; init; } = [];

    [IsoId("_xLEAUUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Item Correction")]
    [IsoXmlTag("SvcItmCrrctn")]
    public ValueList<ServiceItemTotals13> ServiceItemCorrection { get; init; } = [];
}
