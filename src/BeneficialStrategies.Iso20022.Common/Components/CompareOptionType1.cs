// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a option type.
/// </summary>
[IsoId("_VKvTQE6lEeyEpI66tm807w")]
[DisplayName("Compare Option Type")]
public record CompareOptionType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_cCOIcE6lEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public OptionType2Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_d1XhEE6lEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public OptionType2Code? Value2 { get; init; }
}
