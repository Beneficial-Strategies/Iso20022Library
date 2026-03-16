// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Classification2.
/// </summary>
[IsoId("_iWdMYRA6Ee6N57R8Wekj-w")]
[DisplayName("Order Classification2")]
public record OrderClassification2
{
    /// <summary>
    /// Order Type.
    /// </summary>
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public IsoMax50Text? OrderType { get; init; }

    /// <summary>
    /// Order Type Classification.
    /// </summary>
    [DisplayName("Order Type Classification")]
    [IsoXmlTag("OrdrTpClssfctn")]
    public OrderType3Code? OrderTypeClassification { get; init; }
}
