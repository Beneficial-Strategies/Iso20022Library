// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Split Trade Details5.
/// </summary>
[IsoId("_j_ONR0j3Ee-KhcStGV4xTg")]
[DisplayName("Split Trade Details5")]
public record SplitTradeDetails5
{
    /// <summary>
    /// Agreed Rate.
    /// </summary>
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate3? AgreedRate { get; init; }

    /// <summary>
    /// Status Details.
    /// </summary>
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public TradeData16? StatusDetails { get; init; }

    /// <summary>
    /// Trade Amounts.
    /// </summary>
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate8 TradeAmounts { get; init; }
}
