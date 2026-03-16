// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a rate basis.
/// </summary>
[IsoId("_ywFBYdSaEemZdYGWu384Zw")]
[DisplayName("Compare Rate Basis")]
public record CompareRateBasis2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_y0rNgdSaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public RateBasis1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_y0rNg9SaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public RateBasis1Code? Value2 { get; init; }
}
