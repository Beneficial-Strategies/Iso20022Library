// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product8.
/// </summary>
[IsoId("_XHqqYXTwEe6h-4AZRg9sVg")]
[DisplayName("Product8")]
public record Product8
{
    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax70Text? Code { get; init; }

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }
}
