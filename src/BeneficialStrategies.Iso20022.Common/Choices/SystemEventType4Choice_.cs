// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of system event.
    /// </summary>
    [KnownType(typeof(SystemEventType4Choice.Code))]
    [KnownType(typeof(SystemEventType4Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemEventType4Choice.Code), nameof(SystemEventType4Choice.Code))]
    [JsonDerivedType(
        typeof(SystemEventType4Choice.Proprietary),
        nameof(SystemEventType4Choice.Proprietary)
    )]
    [IsoId("_d7AQEXhkEeidzqjNEfehPg")]
    [DisplayName("System Event Type 4 Choice")]
    public abstract record SystemEventType4Choice_ { }
}
