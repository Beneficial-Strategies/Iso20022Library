// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the number of occurrences of a particular event and the maximum number of times this event may occur.
/// </summary>
[IsoId("_RJpGpNp-Ed-ak6NoX_4Aeg_-234268618")]
[DisplayName("Limit")]
public record Limit1
{
    /// <summary>
    /// Number of occurrences of a particular event.
    /// </summary>
    [IsoId("_RJpGpdp-Ed-ak6NoX_4Aeg_-195483682")]
    [DisplayName("Current")]
    [IsoXmlTag("Cur")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText Current { get; init; }

    /// <summary>
    /// Specifies the maximum number of times an event may occur.
    /// </summary>
    [IsoId("_RJpGptp-Ed-ak6NoX_4Aeg_78802724")]
    [DisplayName("Limit")]
    [IsoXmlTag("Lmt")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText Limit { get; init; }
}
