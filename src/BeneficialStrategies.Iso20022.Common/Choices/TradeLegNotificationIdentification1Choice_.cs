// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Leg Notification Identification1Choice.
    /// </summary>
    [KnownType(typeof(TradeLegNotificationIdentification1Choice.TradeLegNotificationIdentification))]
    [KnownType(typeof(TradeLegNotificationIdentification1Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(typeof(TradeLegNotificationIdentification1Choice.TradeLegNotificationIdentification),nameof(TradeLegNotificationIdentification1Choice.TradeLegNotificationIdentification))]
    [JsonDerivedType(typeof(TradeLegNotificationIdentification1Choice.UniqueTransactionIdentifier),nameof(TradeLegNotificationIdentification1Choice.UniqueTransactionIdentifier))]
    [IsoId("_5vhw04cREe-U27oWwgmhCQ")]
    [DisplayName("Trade Leg Notification Identification1Choice")]
    public abstract partial record TradeLegNotificationIdentification1Choice_
    {
    }
}
