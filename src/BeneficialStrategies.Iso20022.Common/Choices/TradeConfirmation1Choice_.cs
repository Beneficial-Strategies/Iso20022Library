// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information regarding the confirmation of the contract.
    /// </summary>
    [KnownType(typeof(TradeConfirmation1Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation1Choice.NonConfirmed))]
    [JsonDerivedType(typeof(TradeConfirmation1Choice.Confirmed),nameof(TradeConfirmation1Choice.Confirmed))]
    [JsonDerivedType(typeof(TradeConfirmation1Choice.NonConfirmed),nameof(TradeConfirmation1Choice.NonConfirmed))]
    [IsoId("_L6EzwQ26EeWmAKKPnqYEVQ")]
    [DisplayName("Trade Confirmation 1 Choice")]
    public abstract partial record TradeConfirmation1Choice_
    {
    }
}
