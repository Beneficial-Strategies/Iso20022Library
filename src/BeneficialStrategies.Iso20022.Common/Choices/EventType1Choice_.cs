// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of the event.
    /// </summary>
    [KnownType(typeof(EventType1Choice.Code))]
    [KnownType(typeof(EventType1Choice.Proprietary))]
    [JsonDerivedType(typeof(EventType1Choice.Code), nameof(EventType1Choice.Code))]
    [JsonDerivedType(typeof(EventType1Choice.Proprietary), nameof(EventType1Choice.Proprietary))]
    [IsoId("_71C2RqMgEeCJ6YNENx4h-w_337125079")]
    [DisplayName("Event Type 1 Choice")]
    public abstract record EventType1Choice_ { }
}
