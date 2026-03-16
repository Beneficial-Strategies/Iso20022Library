// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an exposure type.
/// </summary>
[IsoId("_ohc8IdSYEemZdYGWu384Zw")]
[DisplayName("Compare Exposure Type")]
public record CompareExposureType2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_omjekdSYEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ExposureType6Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_omjek9SYEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ExposureType6Code? Value2 { get; init; }
}
