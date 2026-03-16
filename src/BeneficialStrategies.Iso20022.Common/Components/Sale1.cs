// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of good and services included in the sale.
/// </summary>
[IsoId("_MIdVI_JuEeiJn9rM2Znz2w")]
[DisplayName("Sale")]
public record Sale1
{
    /// <summary>
    /// Sale summary information.
    /// </summary>
    [IsoId("_MId8MPJuEeiJn9rM2Znz2w")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public SaleSummary1? Summary { get; init; }

    /// <summary>
    /// Sale line item information.
    /// </summary>
    [IsoId("_MIdVJPJuEeiJn9rM2Znz2w")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public SaleItem2? LineItem { get; init; }
}
