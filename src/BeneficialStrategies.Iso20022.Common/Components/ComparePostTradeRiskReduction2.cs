// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a post trade risk reduction.
/// </summary>
[IsoId("__B6gAVo3Ee23K4GXSpBSeg")]
[DisplayName("Compare Post Trade Risk Reduction")]
public record ComparePostTradeRiskReduction2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("__DnwMVo3Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public PTRREvent3? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("__DnwM1o3Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public PTRREvent3? Value2 { get; init; }
}
