// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of system event.
    /// </summary>
    [KnownType(typeof(SystemEventType3Choice.Code))]
    [KnownType(typeof(SystemEventType3Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemEventType3Choice.Code),nameof(SystemEventType3Choice.Code))]
    [JsonDerivedType(typeof(SystemEventType3Choice.Proprietary),nameof(SystemEventType3Choice.Proprietary))]
    [IsoId("_wCNH48lcEeW3r6pl_9_bpw")]
    [DisplayName("System Event Type 3 Choice")]
    public abstract partial record SystemEventType3Choice_
    {
    }
}
