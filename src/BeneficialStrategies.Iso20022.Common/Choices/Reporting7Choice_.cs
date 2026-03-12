// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting7Choice.Code))]
    [KnownType(typeof(Reporting7Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting7Choice.Code),nameof(Reporting7Choice.Code))]
    [JsonDerivedType(typeof(Reporting7Choice.Proprietary),nameof(Reporting7Choice.Proprietary))]
    [IsoId("_u3ZOQTxJEeW5v6FXICU4Ew")]
    [DisplayName("Reporting 7 Choice")]
    public abstract partial record Reporting7Choice_
    {
    }
}
