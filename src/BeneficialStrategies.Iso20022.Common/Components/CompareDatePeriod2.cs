// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a date period.
/// </summary>
[IsoId("_0IBd8Vo6Ee23K4GXSpBSeg")]
[DisplayName("Compare Date Period")]
public record CompareDatePeriod2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_0KFTcVo6Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public DatePeriod4? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_0KFTc1o6Ee23K4GXSpBSeg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public DatePeriod4? Value2 { get; init; }
}
