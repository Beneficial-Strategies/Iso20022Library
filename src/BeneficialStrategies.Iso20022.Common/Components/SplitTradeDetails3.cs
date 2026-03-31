// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing the high level details of a split trade.
/// </summary>
[IsoId("_Li4wUaAiEea9x5aZm6UTkw")]
[DisplayName("Split Trade Details")]
public record SplitTradeDetails3
{
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the system.
    /// </summary>
    [IsoId("_LtnZoaAiEea9x5aZm6UTkw")]
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public TradeData16? StatusDetails { get; init; }

    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_LtnZo6AiEea9x5aZm6UTkw")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_LtnZpaAiEea9x5aZm6UTkw")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate3? AgreedRate { get; init; }
}
