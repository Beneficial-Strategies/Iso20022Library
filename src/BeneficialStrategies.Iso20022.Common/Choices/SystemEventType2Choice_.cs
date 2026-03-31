// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of system event.
    /// </summary>
    [KnownType(typeof(SystemEventType2Choice.Code))]
    [KnownType(typeof(SystemEventType2Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemEventType2Choice.Code), nameof(SystemEventType2Choice.Code))]
    [JsonDerivedType(
        typeof(SystemEventType2Choice.Proprietary),
        nameof(SystemEventType2Choice.Proprietary)
    )]
    [IsoId("_717nF6MgEeCJ6YNENx4h-w_-1478283975")]
    [DisplayName("System Event Type 2 Choice")]
    public abstract record SystemEventType2Choice_ { }
}
