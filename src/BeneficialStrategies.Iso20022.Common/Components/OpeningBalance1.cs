// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
/// </summary>
[IsoId("_R9Wbitp-Ed-ak6NoX_4Aeg_991113889")]
[DisplayName("Opening Balance")]
public record OpeningBalance1
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_R9gMgNp-Ed-ak6NoX_4Aeg_-2142989493")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_R9gMgdp-Ed-ak6NoX_4Aeg_-2058025502")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public required OpeningBalance1Choice_ OpeningBalance { get; init; }
}
