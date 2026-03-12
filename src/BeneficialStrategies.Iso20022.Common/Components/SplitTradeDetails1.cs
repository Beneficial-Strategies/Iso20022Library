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
[IsoId("_Ijrm0CNEEeKkK9gFRqAdSA")]
[DisplayName("Split Trade Details")]
public partial record SplitTradeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the system.
    /// </summary>
    [IsoId("_-Vb15SNeEeKkK9gFRqAdSA")]
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public TradeData9? StatusDetails { get; init; } 
    
    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_FxAPlSNfEeKkK9gFRqAdSA")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_HUyWhSNfEeKkK9gFRqAdSA")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate1? AgreedRate { get; init; } 
    
    
    #nullable disable
    
}
