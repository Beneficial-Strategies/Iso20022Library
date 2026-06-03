// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies totals related to the invoice.
/// </summary>
[IsoId("_xQ9M3Uw0EfCpsI1b9uv5FQ")]
[DisplayName("Invoice Totals8")]
public record InvoiceTotals8
{
    /// <summary>
    /// Unique identification of a securities account or cash account belonging to billed customer.
    /// </summary>
    [IsoId("_xSwjoUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification38Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Specifies totals related to the invoice.
    /// </summary>
    [IsoId("_xSwjo0w0EfCpsI1b9uv5FQ")]
    [DisplayName("Invoice Totals")]
    [IsoXmlTag("InvcTtls")]
    public required InvoiceTotals7 InvoiceTotals { get; init; }

    /// <summary>
    /// Specifies totals related to the service category.
    /// </summary>
    [IsoId("_xSwjpUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Service Category Totals")]
    [IsoXmlTag("SvcCtgyTtls")]
    [MinLength(1)]
    public ValueList<ServiceCategoryTotals7> ServiceCategoryTotals { get; init; } = [];
}
