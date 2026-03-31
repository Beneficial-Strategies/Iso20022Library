// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Post Trade Event Type2Choice.
    /// </summary>
    [KnownType(typeof(PostTradeEventType2Choice.Code))]
    [KnownType(typeof(PostTradeEventType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PostTradeEventType2Choice.Code),
        nameof(PostTradeEventType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PostTradeEventType2Choice.Proprietary),
        nameof(PostTradeEventType2Choice.Proprietary)
    )]
    [IsoId("_6NBoAUj-Ee-KhcStGV4xTg")]
    [DisplayName("Post Trade Event Type2Choice")]
    public abstract record PostTradeEventType2Choice_ { }
}
