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
[IsoId("_Mp-n-znGEeWV5sr121Fc8A")]
[DisplayName("Opening Balance")]
public record OpeningBalance3
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_NIehwznGEeWV5sr121Fc8A")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_NIehyznGEeWV5sr121Fc8A")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public required OpeningBalance4Choice_ OpeningBalance { get; init; }
}
