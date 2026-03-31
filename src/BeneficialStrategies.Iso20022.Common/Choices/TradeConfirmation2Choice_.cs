// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information regarding the confirmation of the contract.
    /// </summary>
    [KnownType(typeof(TradeConfirmation2Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation2Choice.NonConfirmed))]
    [JsonDerivedType(
        typeof(TradeConfirmation2Choice.Confirmed),
        nameof(TradeConfirmation2Choice.Confirmed)
    )]
    [JsonDerivedType(
        typeof(TradeConfirmation2Choice.NonConfirmed),
        nameof(TradeConfirmation2Choice.NonConfirmed)
    )]
    [IsoId("_qQg6EQFXEeaDfK-zDSyB6A")]
    [DisplayName("Trade Confirmation 2 Choice")]
    public abstract record TradeConfirmation2Choice_ { }
}
