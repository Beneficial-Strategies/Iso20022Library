// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing the high level details of a split trade.
/// </summary>
[IsoId("_dCfNcQNhEe2-vqzwMUAewg")]
[DisplayName("Split Trade Details")]
public partial record SplitTradeDetails4
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the system.
    /// </summary>
    [IsoId("_dH88QQNhEe2-vqzwMUAewg")]
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public TradeData16? StatusDetails { get; init; } 
    
    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_dH88QwNhEe2-vqzwMUAewg")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate6 TradeAmounts { get; init; } 
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_dH88RQNhEe2-vqzwMUAewg")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate3? AgreedRate { get; init; } 
    
    
    #nullable disable
    
}
