// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a country code.
/// </summary>
[IsoId("_QtxKsdR7EemZdYGWu384Zw")]
[DisplayName("Compare Country Code")]
public record CompareCountryCode2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_Qxxg8dR7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public CountryCode? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Qxxg89R7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public CountryCode? Value2 { get; init; }
}
