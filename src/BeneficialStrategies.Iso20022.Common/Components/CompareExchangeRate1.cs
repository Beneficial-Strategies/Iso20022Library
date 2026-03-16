// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a exchange rate.
/// </summary>
[IsoId("_bmtcsE6bEeyEpI66tm807w")]
[DisplayName("Compare Exchange Rate")]
public record CompareExchangeRate1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_hJhlAE6bEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_jCxloE6bEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? Value2 { get; init; }
}
