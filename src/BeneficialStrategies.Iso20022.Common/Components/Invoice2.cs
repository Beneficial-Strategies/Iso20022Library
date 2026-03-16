// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice data pertaining to the payment transaction.
/// </summary>
[IsoId("_VqOOwcWkEeuhguwJmlgagQ")]
[DisplayName("Invoice")]
public record Invoice2
{
    /// <summary>
    /// Invoice summary information.
    /// </summary>
    [IsoId("_VuiHAcWkEeuhguwJmlgagQ")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public InvoiceSummary2? Summary { get; init; }

    /// <summary>
    /// Line item information.
    /// </summary>
    [IsoId("_VuiHA8WkEeuhguwJmlgagQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public InvoiceLineItem2? LineItem { get; init; }
}
