// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Gross clearing control totals.
/// </summary>
[IsoId("_M0vWkZM1EeuleeHpFMMhmQ")]
[DisplayName("Clearing Control Totals")]
public record ClearingControlTotals2
{
    /// <summary>
    /// Number of clearing transactions. To be used for control purpose.
    /// </summary>
    [IsoId("_M5Z0IZM1EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Control Count")]
    [IsoXmlTag("ClrCtrlCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ClearingControlCount { get; init; }

    /// <summary>
    /// Gross accumulated amount of clearing. To be used for control purpose.
    /// </summary>
    [IsoId("_M5Z0I5M1EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Control Amount")]
    [IsoXmlTag("ClrCtrlAmt")]
    public required Amount17 ClearingControlAmount { get; init; }
}
