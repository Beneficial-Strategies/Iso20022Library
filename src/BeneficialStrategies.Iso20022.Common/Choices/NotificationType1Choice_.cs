// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Notification Type1Choice.
    /// </summary>
    [KnownType(typeof(NotificationType1Choice.Code))]
    [KnownType(typeof(NotificationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(NotificationType1Choice.Code),nameof(NotificationType1Choice.Code))]
    [JsonDerivedType(typeof(NotificationType1Choice.Proprietary),nameof(NotificationType1Choice.Proprietary))]
    [IsoId("_KYeWkLkuEe68nbz8Nl_hLQ")]
    [DisplayName("Notification Type1Choice")]
    public abstract partial record NotificationType1Choice_
    {
    }
}
