// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a CFI identifier.
/// </summary>
[IsoId("_uo6lQdR6EemZdYGWu384Zw")]
[DisplayName("Compare CFI Identifier")]
public record CompareCFIIdentifier2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_us004dR6EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_us0049R6EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? Value2 { get; init; }
}
