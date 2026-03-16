// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
/// </summary>
[IsoId("_qTJdkJP9EemyZbjY08A1Vw")]
[DisplayName("Cash All")]
public record CashAll1
{
    /// <summary>
    /// Indicates whether all assets in the portfolio are to be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_R16NMJwBEem1d_TPEahrAw")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Indicator { get; init; }

    /// <summary>
    /// Currency of the cash.
    /// </summary>
    [IsoId("_woQlgZP9EemyZbjY08A1Vw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }
}
