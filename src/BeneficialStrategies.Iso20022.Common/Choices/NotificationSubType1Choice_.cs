// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Notification Sub Type1Choice.
    /// </summary>
    [KnownType(typeof(NotificationSubType1Choice.Code))]
    [KnownType(typeof(NotificationSubType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NotificationSubType1Choice.Code),
        nameof(NotificationSubType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(NotificationSubType1Choice.Proprietary),
        nameof(NotificationSubType1Choice.Proprietary)
    )]
    [IsoId("_oUxLMLkuEe68nbz8Nl_hLQ")]
    [DisplayName("Notification Sub Type1Choice")]
    public abstract record NotificationSubType1Choice_ { }
}
