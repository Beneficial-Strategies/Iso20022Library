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
[IsoId("_R9Wbgdp-Ed-ak6NoX_4Aeg_-1761574793")]
[DisplayName("Closing Balance")]
public record ClosingBalance1
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_R9Wbgtp-Ed-ak6NoX_4Aeg_-1761574758")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_R9Wbg9p-Ed-ak6NoX_4Aeg_-1761574698")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public required ClosingBalance1Choice_ ClosingBalance { get; init; }
}
