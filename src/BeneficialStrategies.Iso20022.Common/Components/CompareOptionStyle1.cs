// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a option style.
/// </summary>
[IsoId("_s87WEE6lEeyEpI66tm807w")]
[DisplayName("Compare Option Style")]
public record CompareOptionStyle1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_2QfMIE6lEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public OptionStyle6Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_4V4yYE6lEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public OptionStyle6Code? Value2 { get; init; }
}
