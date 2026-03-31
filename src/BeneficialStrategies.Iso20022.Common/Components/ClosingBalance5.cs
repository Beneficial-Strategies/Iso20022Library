// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
/// </summary>
[IsoId("_BRKdmyp8EeyR9JrVGfaMKw")]
[DisplayName("Closing Balance")]
public record ClosingBalance5
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_BpAVYyp8EeyR9JrVGfaMKw")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_BpAVayp8EeyR9JrVGfaMKw")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public required ClosingBalance6Choice_ ClosingBalance { get; init; }
}
