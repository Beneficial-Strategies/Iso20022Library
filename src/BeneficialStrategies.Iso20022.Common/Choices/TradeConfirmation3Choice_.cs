// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information regarding the confirmation of the contract.
    /// </summary>
    [KnownType(typeof(TradeConfirmation3Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation3Choice.NonConfirmed))]
    [JsonDerivedType(typeof(TradeConfirmation3Choice.Confirmed),nameof(TradeConfirmation3Choice.Confirmed))]
    [JsonDerivedType(typeof(TradeConfirmation3Choice.NonConfirmed),nameof(TradeConfirmation3Choice.NonConfirmed))]
    [IsoId("_POyMsVo3Ee23K4GXSpBSeg")]
    [DisplayName("Trade Confirmation 3 Choice")]
    public abstract partial record TradeConfirmation3Choice_
    {
    }
}
